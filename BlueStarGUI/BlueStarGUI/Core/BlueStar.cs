using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace BlueStarGUI.Core
{
    class BlueStarTaskContext
    {
        public delegate void BlueStarTaskDelegate(BlueStarTaskContext taskObject);

        public BlueStarTaskDelegate Delegate { get; set; }
        public BaramClient Client { get; set; }

        public long IntervalMs { get; set; }

        /// <summary>
        /// 아래 변수는 손대지 말 것! (특정 상황이 아니면)
        /// </summary>
        public long NextExcuteTimeMs { get; set; }
    }

    class BlueStar
    {
        private static Dictionary<BaramClient, List<BlueStarTaskContext>> _runningTaskQueue = new Dictionary<BaramClient, List<BlueStarTaskContext>>();
        private static Dictionary<BaramClient, List<BlueStarTaskContext>> _waitTaskQueue = new Dictionary<BaramClient, List<BlueStarTaskContext>>();
        private static object _lock = new object();
        private static Thread _thread = null;
        private static volatile bool _isRunning = false;

        /// <summary>
        /// 프로그램이 실행 되고 난 이후의 elapsed time을 기록 해둔 변수
        /// </summary>
        private static Stopwatch _stopwatch = new Stopwatch();

        public static void Run()
        {
            _thread = new Thread(Procedure);
            _isRunning = true;
            _thread.Start();

            _stopwatch.Start();
        }

        public static void Stop()
        {
            _isRunning = false;

            // 워커 스레드가 종료 될때까지 대기
            while(_thread.IsAlive == true)
            {
                Thread.Sleep(10);
            }

            _stopwatch.Stop();
        }

        /// <summary>
        /// BlueStar의 핵심 로직인 작업을 실행하는 워커 스레드 루트 콜입니다.
        /// </summary>
        private static void Procedure()
        {
            while(_isRunning)
            {
                lock(_lock)
                {
                    foreach(var i in _runningTaskQueue)
                    {
                        foreach(var task in i.Value)
                        {
                            if(_stopwatch.ElapsedMilliseconds - task.NextExcuteTimeMs > 0)
                            {
                                // 태스크 실행
                                task.Delegate(task);

                                // 다음 실행 시간 마킹
                                task.NextExcuteTimeMs = _stopwatch.ElapsedMilliseconds + task.IntervalMs;
                            }
                        }
                    }
                }

                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// 새로운 태스크 컨텍스트를 추가한다.
        /// </summary>
        /// <param name="context">추가할 컨텍스트</param>
        private static void AddTaskContext(BlueStarTaskContext context)
        {
            lock(_lock)
            {
                List<BlueStarTaskContext> value = null;
                if(_runningTaskQueue.TryGetValue(context.Client, out value) == false)
                {
                    if (_waitTaskQueue.TryGetValue(context.Client, out value) == false)
                    {
                        value = new List<BlueStarTaskContext>();
                        _waitTaskQueue.Add(context.Client, value);
                    }
                }

                value.Add(context);
            }
        }

        public static void StartTask(BaramClient client)
        {
            lock (_lock)
            {
                List<BlueStarTaskContext> value = null;
                if (_waitTaskQueue.TryGetValue(client, out value) == false)
                {
                    return;
                }

                // 실행 큐로 옮김
                _waitTaskQueue.Remove(client);
                _runningTaskQueue.Add(client, value);
            }
        }

        public static void StopTask(BaramClient client)
        {
            lock (_lock)
            {
                List<BlueStarTaskContext> value = null;
                if (_runningTaskQueue.TryGetValue(client, out value) == false)
                {
                    return;
                }

                // 대기 큐로 옮김
                _runningTaskQueue.Remove(client);
                _waitTaskQueue.Add(client, value);
            }
        }

        /// <summary>
        /// 현재 클라이언트의 Task가 돌아가고 있는지 여부
        /// </summary>
        /// <param name="client">검사 할 클라이언트 객체</param>
        /// <returns></returns>
        public static bool IsRunning(BaramClient client)
        {
            lock(_lock)
            {
                return _runningTaskQueue.ContainsKey(client);
            }
        }

        /// <summary>
        /// 시약 제조 기능 태스크를 추가 한다.
        /// </summary>
        /// <param name="client">유니크한 바람 클라이언트</param>
        /// <param name="style">시약 제조의 스타일</param>
        /// <param name="level">시약 제조 레벨 선택</param>
        /// <param name="type">시약 제조 물품을 어떤걸로 만들지 선택</param>
        public static void AddTask_ReagentCreation(BaramClient client, 
            ReagentCreation.CollectType collectType,
            ReagentCreation.Type type)
        {
            ReagentCreation.TaskContext context = new ReagentCreation.TaskContext();
            context.Client = client;
            context.Delegate = ReagentCreation.TaskFunctions.DoMakeReagentLevelUp;
            context.collectType = collectType;
            context.type = type;
            context.IntervalMs = 1 * 60 * 1000;
            AddTaskContext(context);
        }

        /// <summary>
        /// 한방굴 자동 사냥 태스크를 추가 한다.
        /// </summary>
        /// <param name="client">유니크한 바람 클라이언트</param>
        /// <param name="type">직업</param>
        public static void AddTask_BETA_AutoOnshotDungeon(BaramClient client,
            OneshotDungeon.Type type)
        {
            OneshotDungeon.TaskContext context = new OneshotDungeon.TaskContext();
            context.Client = client;
            context.Delegate = OneshotDungeon.TaskFunctions.DoOneshotDungeon;
            context.type = type;
            context.IntervalMs = 0;
            AddTaskContext(context);
        }
    }
}
