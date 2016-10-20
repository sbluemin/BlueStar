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
    public partial class ReagentCreationForm : Form
    {
        private Core.BaramClient _client = null;

        public ReagentCreationForm(Core.BaramClient client)
        {
            InitializeComponent();

            _client = client;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Core.ReagentCreation.CollectType collectType = new Core.ReagentCreation.CollectType();
            Core.ReagentCreation.Type type = new Core.ReagentCreation.Type();
            {
                // 회수 스타일
                if (RadioBtn_ReagentUse.Checked == true)
                {
                    collectType = Core.ReagentCreation.CollectType.Use;
                }
                if (RadioBtn_ReagentCollect.Checked == true)
                {
                    collectType = Core.ReagentCreation.CollectType.Collect;
                }
            }

            {
                // 타입
                if (RadioBtn_ReagentHP_Low.Checked == true)
                {
                    type = Core.ReagentCreation.Type.HP_Low;
                }
                else if (RadioBtn_ReagentHP_Middle.Checked == true)
                {
                    type = Core.ReagentCreation.Type.HP_Middle;
                }
                else if (RadioBtn_ReagentHP_High.Checked == true)
                {
                    type = Core.ReagentCreation.Type.HP_High;
                }
                else if (RadioBtn_ReagentHP_High.Checked == true)
                {
                    type = Core.ReagentCreation.Type.HP_High;
                }
                else if (RadioBtn_ReagentMP_High.Checked == true)
                {
                    type = Core.ReagentCreation.Type.MP_High;
                }
                else if (RadioBtn_ReagentAttackDmgUp.Checked == true)
                {
                    type = Core.ReagentCreation.Type.AttackIncreases;
                }
                else if (RadioBtn_ReagentSpellPower.Checked == true)
                {
                    type = Core.ReagentCreation.Type.SpellIncreases;
                }
                else if (RadioBtn_ReagentCastIncreases.Checked == true)
                {
                    type = Core.ReagentCreation.Type.CastIncreases;
                }
                else if (RadioBtn_ReagentArmorPass.Checked == true)
                {
                    type = Core.ReagentCreation.Type.ArmorPenetration;
                }
                else if (RadioBtn_ReagentIgnoreArmor.Checked == true)
                {
                    type = Core.ReagentCreation.Type.ArmorIgnore;
                }
            }

            Core.BlueStar.AddTask_ReagentCreation(_client, collectType, type);
            this.Close();
        }
    }
}
