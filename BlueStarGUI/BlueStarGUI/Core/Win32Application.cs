using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStarGUI
{
    class Win32Application
    {
        public Process _proc = null;

        public void SendLeftButtonDown(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_LBUTTONDOWN, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendLeftButtonUp(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_LBUTTONUP, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendLeftButtondblclick(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_LBUTTONDBLCLK, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendRightButtonDown(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_RBUTTONDOWN, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendRightButtonUp(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_RBUTTONUP, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendRightButtondblclick(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_RBUTTONDBLCLK, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendMouseMove(int x, int y)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_MOUSEMOVE, 0, new IntPtr(y * 0x10000 + x));
        }

        public void SendKeyDown(int key)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_KEYDOWN, key, IntPtr.Zero);
        }

        public void SendKeyUp(int key)
        {
            Win32PostMessage.PostMessage(_proc.MainWindowHandle, WMKey.WM_KEYUP, key, new IntPtr(1));
        }

        public void SendChar(char c)
        {
            Win32PostMessage.SendMessage(_proc.MainWindowHandle, WMKey.WM_CHAR, c, IntPtr.Zero);
        }

        public void SendString(string s)
        {
            foreach (char c in s) SendChar(c);
        }

        public void SetFocus()
        {
            Win32PostMessage.SetForegroundWindow(_proc.MainWindowHandle);
        }
    }
}
