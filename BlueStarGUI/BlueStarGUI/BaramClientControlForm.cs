using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStarGUI
{
    public partial class BaramClientControlForm : Form
    {
        private Core.BaramClient _client = null;
        public Core.BaramClient Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;

                // 이미 등록 된 클라라면 폼 데이터 초기화도 시킴
                if(_client.IsRegistered() == true)
                {
                    TextBox_RealClientName.Text = _client.GetClientTitle();

                    // 현재 상태에 따른 버튼 처리
                    if(Core.BlueStar.IsRunning(_client) == true)
                    {
                        ProcessStartBtnClick_ButtonEnabled();
                    }
                    else
                    {
                        ProcessStopBtnClick_ButtonEnabled();
                    }
                }
            }
        }

        public BaramClientControlForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 바람 클라이언트가 등록 되어 있는지 체크하고 등록 되어 있지 않다면 메시지 박스를 띄운다.
        /// </summary>
        private bool CheckAndShowNotRegisteredClient()
        {
            if (_client.IsRegistered() == false)
            {
                MessageBox.Show("바람 클라이언트를 선택 하십시오.");
                return false;
            }

            return true;
        }

        private void ProcessStartBtnClick_ButtonEnabled()
        {
            // 시작했으니 시작 버튼은 비활성화
            Btn_Start.Enabled = false;

            // 시작했으니 중지 버튼은 활성화
            Btn_Stop.Enabled = true;
        }

        private void ProcessStopBtnClick_ButtonEnabled()
        {
            // 중지했으니 시작 버튼은 활성화
            Btn_Start.Enabled = true;

            // 중지했으니 중지 버튼은 비활성화
            Btn_Stop.Enabled = false;
        }

        private void Button_RegisterBaramClient_Click(object sender, EventArgs e)
        {
            CaptureViewForm form = new CaptureViewForm(_client);
            form.ShowDialog();
            form.Focus();

            string ret_string = "";
            ret_string = TextBox_WantClientName.Text;

            if (_client.IsRegistered() == false)
            {
                ret_string = "Invalid Client.";
            }
            else
            {
                TextBox_RealClientName.Text = ret_string;
                _client.SetClientTitle(ret_string);
            }
        }

        private void Btn_RegisterBaramClientOld_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);

            string ret_string = "";
            if (_client.RegisterForegroundWindows() == false)
            {
                ret_string = "Invalid Client.";
            }
            else
            {
                ret_string = TextBox_WantClientName.Text;
            }

            TextBox_RealClientName.Text = ret_string;
            _client.SetClientTitle(ret_string);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (CheckAndShowNotRegisteredClient() == false)
            {
                return;
            }

            ProcessStartBtnClick_ButtonEnabled();
            Core.BlueStar.StartTask(_client);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (CheckAndShowNotRegisteredClient() == false)
            {
                return;
            }

            ProcessStopBtnClick_ButtonEnabled();
            Core.BlueStar.StopTask(_client);
        }

        private void Btn_ReagentCreation_Click(object sender, EventArgs e)
        {
            if (CheckAndShowNotRegisteredClient() == false)
            {
                return;
            }

            MacroFunctionalForms.ReagentCreationForm form = new MacroFunctionalForms.ReagentCreationForm(_client);
            form.ShowDialog();
        }

        private void Btn_OneshotDungeon_Click(object sender, EventArgs e)
        {
            if (CheckAndShowNotRegisteredClient() == false)
            {
                return;
            }

            MacroFunctionalForms.OneshotDungeonForm form = new MacroFunctionalForms.OneshotDungeonForm(_client);
            form.ShowDialog();
        }
    }
}
