namespace BlueStarGUI
{
    partial class BaramClientForm
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
            this.Client_1 = new System.Windows.Forms.Button();
            this.Client_2 = new System.Windows.Forms.Button();
            this.Client_4 = new System.Windows.Forms.Button();
            this.Client_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_isAdministrator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Client_1
            // 
            this.Client_1.Location = new System.Drawing.Point(23, 48);
            this.Client_1.Name = "Client_1";
            this.Client_1.Size = new System.Drawing.Size(116, 85);
            this.Client_1.TabIndex = 0;
            this.Client_1.Text = "클라1";
            this.Client_1.UseVisualStyleBackColor = true;
            this.Client_1.Click += new System.EventHandler(this.Client_1_Click);
            // 
            // Client_2
            // 
            this.Client_2.Location = new System.Drawing.Point(157, 48);
            this.Client_2.Name = "Client_2";
            this.Client_2.Size = new System.Drawing.Size(116, 85);
            this.Client_2.TabIndex = 1;
            this.Client_2.Text = "클라2";
            this.Client_2.UseVisualStyleBackColor = true;
            this.Client_2.Click += new System.EventHandler(this.Client_2_Click);
            // 
            // Client_4
            // 
            this.Client_4.Location = new System.Drawing.Point(157, 157);
            this.Client_4.Name = "Client_4";
            this.Client_4.Size = new System.Drawing.Size(116, 85);
            this.Client_4.TabIndex = 3;
            this.Client_4.Text = "클라4";
            this.Client_4.UseVisualStyleBackColor = true;
            this.Client_4.Click += new System.EventHandler(this.Client_4_Click);
            // 
            // Client_3
            // 
            this.Client_3.Location = new System.Drawing.Point(23, 157);
            this.Client_3.Name = "Client_3";
            this.Client_3.Size = new System.Drawing.Size(116, 85);
            this.Client_3.TabIndex = 2;
            this.Client_3.Text = "클라3";
            this.Client_3.UseVisualStyleBackColor = true;
            this.Client_3.Click += new System.EventHandler(this.Client_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "관리자 권한 실행 여부:";
            // 
            // lbl_isAdministrator
            // 
            this.lbl_isAdministrator.AutoSize = true;
            this.lbl_isAdministrator.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_isAdministrator.ForeColor = System.Drawing.Color.Red;
            this.lbl_isAdministrator.Location = new System.Drawing.Point(157, 19);
            this.lbl_isAdministrator.Name = "lbl_isAdministrator";
            this.lbl_isAdministrator.Size = new System.Drawing.Size(23, 12);
            this.lbl_isAdministrator.TabIndex = 5;
            this.lbl_isAdministrator.Text = "Off";
            // 
            // BaramClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.lbl_isAdministrator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Client_4);
            this.Controls.Add(this.Client_3);
            this.Controls.Add(this.Client_2);
            this.Controls.Add(this.Client_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BaramClientForm";
            this.Text = "BlueStar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Client_1;
        private System.Windows.Forms.Button Client_2;
        private System.Windows.Forms.Button Client_4;
        private System.Windows.Forms.Button Client_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_isAdministrator;
    }
}