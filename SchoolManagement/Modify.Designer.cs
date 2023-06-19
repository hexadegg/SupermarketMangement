namespace SchoolManagement
{
    partial class Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify));
            this.delpanel = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.labelOriginalPwd = new System.Windows.Forms.Label();
            this.delpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // delpanel
            // 
            this.delpanel.Controls.Add(this.txtEmail);
            this.delpanel.Controls.Add(this.label1);
            this.delpanel.Controls.Add(this.btnClose);
            this.delpanel.Controls.Add(this.btnModify);
            this.delpanel.Controls.Add(this.txtOldPwd);
            this.delpanel.Controls.Add(this.labelOriginalPwd);
            this.delpanel.Location = new System.Drawing.Point(12, 12);
            this.delpanel.Name = "delpanel";
            this.delpanel.Size = new System.Drawing.Size(651, 383);
            this.delpanel.TabIndex = 9;
            this.delpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.delpanel_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(187, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '*';
            this.txtEmail.Size = new System.Drawing.Size(208, 28);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "邮箱名：";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(463, 197);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 46);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(463, 99);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(140, 46);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "获取验证码";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(187, 208);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(208, 28);
            this.txtOldPwd.TabIndex = 5;
            this.txtOldPwd.UseSystemPasswordChar = true;
            // 
            // labelOriginalPwd
            // 
            this.labelOriginalPwd.AutoSize = true;
            this.labelOriginalPwd.Location = new System.Drawing.Point(90, 211);
            this.labelOriginalPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOriginalPwd.Name = "labelOriginalPwd";
            this.labelOriginalPwd.Size = new System.Drawing.Size(80, 18);
            this.labelOriginalPwd.TabIndex = 6;
            this.labelOriginalPwd.Text = "验证码：";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 409);
            this.Controls.Add(this.delpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modify";
            this.Text = "Modify";
            this.delpanel.ResumeLayout(false);
            this.delpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel delpanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label labelOriginalPwd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
    }
}