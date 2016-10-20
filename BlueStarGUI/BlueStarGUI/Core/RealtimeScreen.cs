using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlueStarGUI.Core
{
    class RealtimeScreen
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        public Bitmap _bmp = null;
        Rect _rect = new Rect();
        Size _size = new Size();

        Process _proc = null;
        
        public bool IsValid()
        {
            if(_proc != null)
            {
                return true;
            }

            return false;
        }

        public void SetApplication(Process proc)
        {
            _proc = proc;

            IntPtr error = GetWindowRect(_proc.MainWindowHandle, ref _rect);

            // sometimes it gives error.
            while (error == (IntPtr)0)
            {
                error = GetWindowRect(_proc.MainWindowHandle, ref _rect);
            }

            _size.Width = _rect.right - _rect.left;
            _size.Height = _rect.bottom - _rect.top;

            if(_bmp == null)
            {
                _bmp = new Bitmap(_size.Width, _size.Height, PixelFormat.Format32bppArgb);
            }
        }

        public void Capture()
        {
            Rect rect = new Rect();
            IntPtr error = GetWindowRect(_proc.MainWindowHandle, ref rect);

            Graphics.FromImage(_bmp).CopyFromScreen(rect.left, rect.top + 30, 0, 0, _size, CopyPixelOperation.SourceCopy);
        }
    }
}
