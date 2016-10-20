using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication3
{
    class Program
    {

        static void Main(string[] args)
        {
            Win32Application app = new Win32Application();

            Process[] processes = Process.GetProcesses();
            foreach(Process i in processes)
            {
                if(i.ProcessName.CompareTo("gamer") == 0)
                {
                    app._handle = i.MainWindowHandle;
                    break;
                }
            }
            
            app.SendKeyDown(Win32PostMessage.VK_LEFT);
        }
    }
}
