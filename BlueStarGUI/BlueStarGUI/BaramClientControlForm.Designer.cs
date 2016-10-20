namespace BlueStarGUI
{
    partial class BaramClientControlForm
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
            this.Button_RegisterBaramClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_WantClientName = new System.Windows.Forms.TextBox();
            this.TextBox_RealClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_RegisterBaramClientOld = new System.Windows.Forms.Button();
            this.Btn_ReagentCreation = new System.Windows.Forms.Button();
            this.Btn_OneshotDungeon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_RegisterBaramClient
            // 
            this.Button_RegisterBaramClient.Location = new System.Drawing.Point(12, 18);
            this.Button_RegisterBaramClient.Name = "Button_RegisterBaramClient";
            this.Button_RegisterBaramClient.Size = new System.Drawing.Size(175, 49);
            this.Button_RegisterBaramClient.TabIndex = 0;
            this.Button_RegisterBaramClient.Text = "클라이언트 선택 (렌더링)";
            this.Button_RegisterBaramClient.UseVisualStyleBackColor = true;
            this.Button_RegisterBaramClient.Click += new System.EventHandler(this.Button_RegisterBaramClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "클릭 시, 바람의나라 클라이언트를 선택 합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "3초 이내에 원하는 클라이언트를 활성화 시켜야 합니다.";
            // 
            // TextBox_WantClientName
            // 
            this.TextBox_WantClientName.Location = new System.Drawing.Point(312, 74);
            this.TextBox_WantClientName.Name = "TextBox_WantClientName";
            this.TextBox_WantClientName.Size = new System.Drawing.Size(128, 21);
            this.TextBox_WantClientName.TabIndex = 3;
            // 
            // TextBox_RealClientName
            // 
            this.TextBox_RealClientName.Location = new System.Drawing.Point(312, 100);
            this.TextBox_RealClientName.Name = "TextBox_RealClientName";
            this.TextBox_RealClientName.ReadOnly = true;
            this.TextBox_RealClientName.Size = new System.Drawing.Size(128, 21);
            this.TextBox_RealClientName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "원하는 클라 이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "현재 클라 이름";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_OneshotDungeon);
            this.groupBox1.Controls.Add(this.Btn_ReagentCreation);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매크로 기능";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(79, 280);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(134, 51);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "작동";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(286, 280);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(134, 51);
            this.Btn_Stop.TabIndex = 1;
            this.Btn_Stop.Text = "중지";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_RegisterBaramClientOld
            // 
            this.Btn_RegisterBaramClientOld.Location = new System.Drawing.Point(12, 71);
            this.Btn_RegisterBaramClientOld.Name = "Btn_RegisterBaramClientOld";
            this.Btn_RegisterBaramClientOld.Size = new System.Drawing.Size(175, 49);
            this.Btn_RegisterBaramClientOld.TabIndex = 9;
            this.Btn_RegisterBaramClientOld.Text = "클라이언트 선택 (3초 뒤)";
            this.Btn_RegisterBaramClientOld.UseVisualStyleBackColor = true;
            this.Btn_RegisterBaramClientOld.Click += new System.EventHandler(this.Btn_RegisterBaramClientOld_Click);
            // 
            // Btn_ReagentCreation
            // 
            this.Btn_ReagentCreation.Location = new System.Drawing.Point(6, 20);
            this.Btn_ReagentCreation.Name = "Btn_ReagentCreation";
            this.Btn_ReagentCreation.Size = new System.Drawing.Size(136, 56);
            this.Btn_ReagentCreation.TabIndex = 10;
            this.Btn_ReagentCreation.Text = "시약 제조";
            this.Btn_ReagentCreation.UseVisualStyleBackColor = true;
            this.Btn_ReagentCreation.Click += new System.EventHandler(this.Btn_ReagentCreation_Click);
            // 
            // Btn_OneshotDungeon
            // 
            this.Btn_OneshotDungeon.Location = new System.Drawing.Point(151, 20);
            this.Btn_OneshotDungeon.Name = "Btn_OneshotDungeon";
            this.Btn_OneshotDungeon.Size = new System.Drawing.Size(136, 56);
            this.Btn_OneshotDungeon.TabIndex = 11;
            this.Btn_OneshotDungeon.Text = "한방굴 (BETA)";
            this.Btn_OneshotDungeon.UseVisualStyleBackColor = true;
            this.Btn_OneshotDungeon.Click += new System.EventHandler(this.Btn_OneshotDungeon_Click);
            // 
            // BaramClientControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 343);
            this.Controls.Add(this.Btn_RegisterBaramClientOld);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.TextBox_RealClientName);
            this.Controls.Add(this.TextBox_WantClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_RegisterBaramClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BaramClientControlForm";
            this.Text = "BlueStar - 바람 클라이언트 컨트롤";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_RegisterBaramClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_WantClientName;
        private System.Windows.Forms.TextBox TextBox_RealClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_RegisterBaramClientOld;
        private System.Windows.Forms.Button Btn_ReagentCreation;
        private System.Windows.Forms.Button Btn_OneshotDungeon;
    }
}