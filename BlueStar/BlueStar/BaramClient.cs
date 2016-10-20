using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BlueStar
{
    class BaramClient
    {
        private Win32Application _app = new Win32Application();

        private void Delay(int delayMs)
        {
            System.Threading.Thread.Sleep(delayMs);
        }

        private void KeyDelay()
        {
            Delay(300);
        }

        public void SetClientTitle(string name)
        {
            Win32PostMessage.SetWindowText(_app._handle, name);
        }

        /// <summary>
        /// 현재 활성화중인 Windows를 이 객체에 등록 합니다.
        /// </summary>
        /// <returns>활성화 된 Windows가 바람의나라가 아닐 경우 false를 리턴 합니다.</returns>
        public bool RegisterForegroundWindows()
        {
            var activatedHandle = Win32PostMessage.GetForegroundWindow();
            if (activatedHandle == IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            int activeProcId;
            Win32PostMessage.GetWindowThreadProcessId(activatedHandle, out activeProcId);

            Process proc = Process.GetProcessById(activeProcId);
            if (proc.ProcessName.CompareTo("gamer") != 0)
            {
                return false;
            }
            
            _app._handle = proc.MainWindowHandle;

            return true;
        }

        public void Left()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_LEFT);
        }

        public void Right()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_RIGHT);
        }

        public void Up()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_UP);
        }

        public void Down()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_DOWN);
        }

        public void Enter()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_RETURN);
        }

        public void Esc()
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_ESCAPE);
        }

        public void Clear()
        {
            for(int i = 0; i < 5; i++)
            {
                Esc();
            }
        }

        /// <summary>
        /// 아이템을 사용 합니다.
        /// </summary>
        public void UseItem(int key)
        {
            KeyDelay();
            _app.SendKeyDown(WMKey.VK_W);
            KeyDelay();
            _app.SendKeyDown(key);
        }
    }
}
