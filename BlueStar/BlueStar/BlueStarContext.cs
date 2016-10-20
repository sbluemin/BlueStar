using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlueStar
{
    enum ReagentType
    {
        // 공격력 증가
        Hp,
        
        // 마력 회복
        Mp,

        // 공격력 증가
        AttackDmgUp,

        // 방어구관통
        ArmorPenetration,
    }

    class ReagentTaskData
    {
        public int Level { get; set; }
        public ReagentType Reagent { get; set; }
    }

    class BlueStarTask
    {
        public volatile bool Run = false;
        public int Interval { get; set; }

        public delegate void BlueStarTaskDelegate(BlueStarTask taskObject);
        public BlueStarTaskDelegate Delegate { get; set; }
        public BaramClient Client { get; set; }

        public ReagentTaskData ReagentData { get; set; }
    }

    class BlueStarContext
    {
        
        private Thread _thread = null;
        private volatile bool _run = true;

        private List<BlueStarTask> _tasks = new List<BlueStarTask>();

        private object _lock = new object();

        public BlueStarContext()
        {
            _thread = new Thread(Procedure);
            _thread.Start();
        }

        private void Procedure()
        {
            while(_run)
            {
                lock(_lock)
                {
                    foreach (BlueStarTask i in _tasks)
                    {
                        if(i.Run == false)
                        {
                            if(ThreadPool.QueueUserWorkItem(DoTask, i) == true)
                            {
                                i.Run = true;
                            }
                        }
                    }
                }

                Thread.Sleep(10);
            }
        }

        public void End()
        {
            _run = false;
        }

        private void DoTask(object state)
        {
            BlueStarTask task = (BlueStarTask)state;
            task.Delegate(task);
            task.Run = false;
        }

        private void DoMakeReagentLevelUp(BlueStarTask task)
        {
            BaramClient client = task.Client;
            switch(task.ReagentData.Level)
            {
                case 1:
                    // 시약 회수
                    client.Clear();
                    client.UseItem(WMKey.VK_G);
                    client.Up();
                    client.Enter();
                    client.Down();
                    client.Down();
                    client.Enter();
                    client.Down();
                    client.Enter();

                    // 제조
                    client.Clear();
                    client.UseItem(WMKey.VK_G);
                    client.Up();
                    client.Enter();
                    client.Down();
                    client.Enter();
                    client.Down();
                    client.Down();
                    client.Enter();
                    client.Down();
                    client.Enter();
                    client.Enter();

                    // 대기
                    Thread.Sleep(task.Interval);
                    break;
            }
        }

        private void DoTEST_AutoMoving(BlueStarTask task)
        {
            BaramClient client = task.Client;

            client.Up();
            client.Right();
            client.Down();
            client.Left();
        }

        public void AddTaskMakeReagentLevelUp(BaramClient client, int level)
        {
            BlueStarTask task = new BlueStarTask();
            task.Delegate = DoMakeReagentLevelUp;
            task.Client = client;
            task.ReagentData = new ReagentTaskData();
            task.ReagentData.Level = level;
            
            switch(level)
            {
                case 1:
                    // 1단계는 5분 제조 + 딜레이
                    task.Interval = (1 * 60) * 1000 + 1000;
                    break;
            }

            lock(_lock)
            {
                _tasks.Add(task);
            }
        }

        public void AddTaskTEST_AutoMoving(BaramClient client)
        {
            BlueStarTask task = new BlueStarTask();
            task.Delegate = DoTEST_AutoMoving;
            task.Client = client;
            task.Interval = 100;

            lock (_lock)
            {
                _tasks.Add(task);
            }
        }
    }
}
