using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BlueStarGUI.Core
{
    public class BaramClient
    {
        private const int INTERNAL_KEY_DELAY = 300;

        private Win32Application _app = new Win32Application();

        public void Delay(int delayMs)
        {
            System.Threading.Thread.Sleep(delayMs);
        }

        public void SetClientTitle(string name)
        {
            Win32PostMessage.SetWindowText(_app._proc.MainWindowHandle, name);
        }

        public string GetClientTitle()
        {
            StringBuilder sbWinText = new StringBuilder(260);
            Win32PostMessage.GetWindowText(_app._proc.MainWindowHandle, sbWinText, 260);
            return sbWinText.ToString();
        }

        public bool IsRegistered()
        {
            if(_app._proc == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 현재 활성화중인 Windows를 이 객체에 등록 합니다.
        /// </summary>
        /// <returns>활성화 된 Windows가 바람의나라가 아닐 경우 false를 리턴 합니다.</returns>
        public bool Register(Process proc)
        {
            if (proc.ProcessName.CompareTo("gamer") != 0)
            {
                return false;
            }

            _app._proc = proc;

            return true;
        }

        /// <summary>
        /// 현재 선택 된 윈도우 창을 클라이언트로 등록
        /// </summary>
        /// <returns></returns>
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

            _app._proc = proc;

            return true;
        }

        /// <summary>
        /// 현재 등록된 클라이언트를 떼어 냅니다.
        /// </summary>
        public void Unregister()
        {
            SetClientTitle("바람의나라");
            _app._proc = null;
        }

        /// <summary>
        /// 바람의나라에서 아무런 상태를 가지지 않기 위한 '클린' 상태를 만듭니다.
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < 5; i++)
            {
                Esc();
                Delay(INTERNAL_KEY_DELAY);
            }
        }

        public void Clear(int delay)
        {
            for (int i = 0; i < 5; i++)
            {
                Esc();
                Delay(delay);
            }
        }

        /// <summary>
        /// 방향키 왼쪽입니다.
        /// </summary>
        public void Left()
        {
            _app.SendKeyDown(WMKey.VK_LEFT);
            Delay(INTERNAL_KEY_DELAY);
        }

        /// <summary>
        /// 방향키 오른쪽입니다.
        /// </summary>
        public void Right()
        {
            _app.SendKeyDown(WMKey.VK_RIGHT);
            Delay(INTERNAL_KEY_DELAY);
        }

        /// <summary>
        /// 방향키 위쪽입니다.
        /// </summary>
        public void Up()
        {
            _app.SendKeyDown(WMKey.VK_UP);
            Delay(INTERNAL_KEY_DELAY);
        }

        public void Up(int delay)
        {
            _app.SendKeyDown(WMKey.VK_UP);
            Delay(delay);
        }

        /// <summary>
        /// 방향키 아래쪽입니다.
        /// </summary>
        public void Down()
        {
            _app.SendKeyDown(WMKey.VK_DOWN);
            Delay(INTERNAL_KEY_DELAY);
        }

        /// <summary>
        /// 엔터키 입니다.
        /// </summary>
        public void Enter()
        {
            _app.SendKeyDown(WMKey.VK_RETURN);
            Delay(INTERNAL_KEY_DELAY);
        }

        public void Enter(int delay)
        {
            _app.SendKeyDown(WMKey.VK_RETURN);
            Delay(delay);
        }

        /// <summary>
        /// ESC 키 입니다.
        /// </summary>
        public void Esc()
        {
            _app.SendKeyDown(WMKey.VK_ESCAPE);
        }

        /// <summary>
        /// 아이템을 사용 합니다.
        /// </summary>
        public void UseItem(int key)
        {
            _app.SendKeyDown(WMKey.VK_W);
            Delay(INTERNAL_KEY_DELAY);
            _app.SendKeyDown(key);
            Delay(INTERNAL_KEY_DELAY);
        }

        public void UseQuickSlot(int key, int delay)
        {
            _app.SendKeyDown(key);
            Delay(delay);
        }
    }
}
