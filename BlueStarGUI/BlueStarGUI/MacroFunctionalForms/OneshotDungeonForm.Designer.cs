namespace BlueStarGUI.MacroFunctionalForms
{
    partial class OneshotDungeonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtn_Archer = new System.Windows.Forms.RadioButton();
            this.RadioBtn_CreativeGodMan = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Magician = new System.Windows.Forms.RadioButton();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtn_Archer);
            this.groupBox1.Controls.Add(this.RadioBtn_CreativeGodMan);
            this.groupBox1.Controls.Add(this.RadioBtn_Magician);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직업";
            // 
            // RadioBtn_Archer
            // 
            this.RadioBtn_Archer.AutoSize = true;
            this.RadioBtn_Archer.Location = new System.Drawing.Point(20, 65);
            this.RadioBtn_Archer.Name = "RadioBtn_Archer";
            this.RadioBtn_Archer.Size = new System.Drawing.Size(47, 16);
            this.RadioBtn_Archer.TabIndex = 2;
            this.RadioBtn_Archer.TabStop = true;
            this.RadioBtn_Archer.Text = "궁사";
            this.RadioBtn_Archer.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_CreativeGodMan
            // 
            this.RadioBtn_CreativeGodMan.AutoSize = true;
            this.RadioBtn_CreativeGodMan.Location = new System.Drawing.Point(20, 43);
            this.RadioBtn_CreativeGodMan.Name = "RadioBtn_CreativeGodMan";
            this.RadioBtn_CreativeGodMan.Size = new System.Drawing.Size(81, 16);
            this.RadioBtn_CreativeGodMan.TabIndex = 1;
            this.RadioBtn_CreativeGodMan.TabStop = true;
            this.RadioBtn_CreativeGodMan.Text = "천인(창조)";
            this.RadioBtn_CreativeGodMan.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Magician
            // 
            this.RadioBtn_Magician.AutoSize = true;
            this.RadioBtn_Magician.Location = new System.Drawing.Point(20, 21);
            this.RadioBtn_Magician.Name = "RadioBtn_Magician";
            this.RadioBtn_Magician.Size = new System.Drawing.Size(59, 16);
            this.RadioBtn_Magician.TabIndex = 0;
            this.RadioBtn_Magician.TabStop = true;
            this.RadioBtn_Magician.Text = "주술사";
            this.RadioBtn_Magician.UseVisualStyleBackColor = true;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(178, 124);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(113, 48);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "확인";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "천인 -> 퀵슬롯 1. 수구 2. 빙글 3. 하늘기도 4. 불가사리선풍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "궁사 -> 퀵슬롯 3. 탄시 (타겟 지정 방식 2번 필수!)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "주술사 -> 퀵슬롯 1. 공증 2. 성려 (타겟 지정 방식 2번 필수!)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(131, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "한방굴 좌표 4, 9 위치에 두세요!!";
            // 
            // OneshotDungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 195);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "OneshotDungeonForm";
            this.Text = "BlueStar - 한방굴 (BETA)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtn_Archer;
        private System.Windows.Forms.RadioButton RadioBtn_CreativeGodMan;
        private System.Windows.Forms.RadioButton RadioBtn_Magician;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}