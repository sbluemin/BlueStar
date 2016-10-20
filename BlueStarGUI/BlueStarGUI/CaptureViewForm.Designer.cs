namespace BlueStarGUI
{
    partial class CaptureViewForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(12, 344);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(94, 76);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "◁";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(908, 344);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(94, 76);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = "▷";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(472, 344);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 76);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "이거 맞아요!";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // CaptureViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 758);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Name = "CaptureViewForm";
            this.Text = "CaptureViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_ok;
    }
}

