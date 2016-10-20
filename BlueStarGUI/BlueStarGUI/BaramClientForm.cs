using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStarGUI
{
    public partial class BaramClientForm : Form
    {
        const int MAX_BARAM_CLIENT = 4;

        List<Core.BaramClient> _clients = new List<Core.BaramClient>();
        Dictionary<int, BaramClientControlForm> _forms = new Dictionary<int, BaramClientControlForm>();

        public BaramClientForm()
        {
            InitializeComponent();

            // 초기 바람 클라이언트 객체를 넣음
            for(int i = 0; i < MAX_BARAM_CLIENT; i ++)
            {
                Core.BaramClient client = new Core.BaramClient();
                _clients.Add(client);
            }

            if(Program.IsAdministrator() == false)
            {
                lbl_isAdministrator.Text = "OFF";
                lbl_isAdministrator.ForeColor = Color.Red;
            }
            else
            {
                lbl_isAdministrator.Text = "ON";
                lbl_isAdministrator.ForeColor = Color.Green;
            }
        }

        private BaramClientControlForm GetControlForm(int clientNumber)
        {
            BaramClientControlForm form = null;
            if (_forms.TryGetValue(clientNumber, out form) == false)
            {
                form = new BaramClientControlForm();
                form.Client = _clients[clientNumber];
                _forms.Add(clientNumber, form);
            }

            if (form.IsDisposed == true)
            {
                _forms.Remove(clientNumber);
                form = null;

                form = new BaramClientControlForm();
                form.Client = _clients[clientNumber];
                _forms.Add(clientNumber, form);
            }

            return form;
        }

        private bool CheckAdministratorAndDenied()
        {
            if(Program.IsAdministrator() == true)
            {
                return true;
            }

            MessageBox.Show("관리자 권한으로 실행해주세요.");

            return false;
        }

        private void Client_1_Click(object sender, EventArgs e)
        {
            if(CheckAdministratorAndDenied() == false)
            {
                return;
            }

            BaramClientControlForm form = GetControlForm(0);
            form.Show();
            form.Focus();
        }

        private void Client_2_Click(object sender, EventArgs e)
        {
            if (CheckAdministratorAndDenied() == false)
            {
                return;
            }

            BaramClientControlForm form = GetControlForm(1);
            form.Show();
            form.Focus();
        }

        private void Client_3_Click(object sender, EventArgs e)
        {
            if (CheckAdministratorAndDenied() == false)
            {
                return;
            }

            BaramClientControlForm form = GetControlForm(2);
            form.Show();
            form.Focus();
        }

        private void Client_4_Click(object sender, EventArgs e)
        {
            if (CheckAdministratorAndDenied() == false)
            {
                return;
            }

            BaramClientControlForm form = GetControlForm(3);
            form.Show();
            form.Focus();
        }
    }
}
