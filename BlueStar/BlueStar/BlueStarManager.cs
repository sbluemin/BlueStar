using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStar
{
    class BlueStarManager
    {
        private BlueStarContext _context = new BlueStarContext();
        private Dictionary<string, BaramClient> _clients = new Dictionary<string, BaramClient>();

        private void Sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        private void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1.작업 클라 추가");
            Console.WriteLine("2.작업 추가");
            Console.WriteLine("3.작업 클라 상태 보기");
            Console.WriteLine("esc. 종료");
        }

        private void WaitForKeyDownAndShowMessage()
        {
            Console.WriteLine("아무 키를 입력하면 메인 메뉴로 갑니다.");
            Console.ReadKey();
        }

        private BaramClient GetClient()
        {
            Console.WriteLine("작업을 할당 할 클라이언트 별명을 입력 해주세요.");
            string name = Console.ReadLine();

            BaramClient client = null;
            if(_clients.TryGetValue(name, out client) == false)
            {
                return null;
            }

            return client;
        }

        private void AddClient()
        {
            Console.WriteLine("작업 클라를 선택합니다.");
            Console.WriteLine("3초 이내에 작업을 원하는 클라이언트를 선택 해주십시오.");

            Sleep(3000);

            BaramClient client = new BaramClient();
            if(client.RegisterForegroundWindows() == false)
            {
                Console.WriteLine("바람의나라 클라이언트가 아닙니다.");
                WaitForKeyDownAndShowMessage();
                return;
            }

            Console.WriteLine("바람의나라 클라이언트 입니다. 별명을 지어주세요.");
            string name = Console.ReadLine();
            _clients.Add(name, client);

            client.SetClientTitle(name);
        }

        private void AddTask()
        {
            BaramClient client = GetClient();

            if (client == null)
            {
                Console.WriteLine("해당 클라이언트가 없습니다.");
                WaitForKeyDownAndShowMessage();
                return;
            }

            _context.AddTaskMakeReagentLevelUp(client, 1);
           // _context.AddTaskTEST_AutoMoving(client);
        }

        private void ShowWorkingClientState()
        {
            WaitForKeyDownAndShowMessage();
        }

        public void Run()
        {
            while(true)
            {
                ShowMainMenu();
                ConsoleKeyInfo key = Console.ReadKey();

                if(key.Key == ConsoleKey.Escape)
                {
                    _context.End();
                    break;
                }

                Console.Clear();
                switch (key.KeyChar)
                {
                    case '1':
                        AddClient();
                        break;

                    case '2':
                        AddTask();
                        break;

                    case '3':
                        ShowWorkingClientState();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
