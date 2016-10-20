using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStarGUI.MacroFunctionalForms
{
    public partial class OneshotDungeonForm : Form
    {
        private Core.BaramClient _client = null;

        public OneshotDungeonForm(Core.BaramClient client)
        {
            InitializeComponent();

            _client = client;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if(RadioBtn_Magician.Checked == true)
            {
                MessageBox.Show("현재 지원되지 않습니다.");
            }
            else if(RadioBtn_CreativeGodMan.Checked == true)
            {
                Core.BlueStar.AddTask_BETA_AutoOnshotDungeon(_client, Core.OneshotDungeon.Type.CreationGodman);
                this.Close();
            }
            else if(RadioBtn_Archer.Checked == true)
            {
                Core.BlueStar.AddTask_BETA_AutoOnshotDungeon(_client, Core.OneshotDungeon.Type.Archer);
                this.Close();
            }
            else
            {
                MessageBox.Show("알 수 없는 직업 입니다.");
            }
        }
    }
}
