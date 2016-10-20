using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStarGUI
{
    public partial class CaptureViewForm : Form
    {
        Timer timer = new Timer();
        private Process[] _proc;
        private int _procNumber = 0;

        Core.RealtimeScreen _rtlScreen = new Core.RealtimeScreen();
        Core.BaramClient _client = null;

        public CaptureViewForm(Core.BaramClient client)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            timer.Enabled = true;
            timer.Interval = 15;  /* 100 millisec */
            timer.Tick += new EventHandler(TimerCallback);

            _proc = Process.GetProcesses();

            _client = client;

            FindFirstBaramClient();
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(_rtlScreen.IsValid() == false)
            {
                return;
            }

            _rtlScreen.Capture();

            // 백버퍼의 Graphics
            using (Graphics g = Graphics.FromImage(_rtlScreen._bmp))
            {
                // 이미지를 그린다.               
                g.DrawImage(_rtlScreen._bmp, 0, 0);
            }
            
            // 백버퍼에 있는 내용을 화면에 그린다.
            e.Graphics.DrawImage(_rtlScreen._bmp, 0, 0);
        }

        private void DetectedNewClient()
        {
            _rtlScreen.SetApplication(_proc[_procNumber]);
        }

        private void FindFirstBaramClient()
        {
            for (int i = 0; i < _proc.Length; i++)
            {
                if (_proc[i].ProcessName.CompareTo("gamer") == 0)
                {
                    _procNumber = i;
                    DetectedNewClient();
                    break;
                }
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            for(int i = _procNumber - 1; i > 0; i--)
            {
                if (_proc[i].ProcessName.CompareTo("gamer") == 0)
                {
                    _procNumber = i;
                    DetectedNewClient();
                    break;
                }
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            for (int i = _procNumber + 1; i < _proc.Length; i++)
            {
                if (_proc[i].ProcessName.CompareTo("gamer") == 0)
                {
                    _procNumber = i;
                    DetectedNewClient();
                    break;
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(_proc[_procNumber].ProcessName.CompareTo("gamer") != 0)
            {
                MessageBox.Show("바람 클라이언트가 아닙니다!");
                return;
            }

            _client.Register(_proc[_procNumber]);

            this.Close();
        }
    }
}
