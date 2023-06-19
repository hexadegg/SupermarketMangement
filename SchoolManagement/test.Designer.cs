namespace SchoolManagement
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.delpanel = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.labelOriginalPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.labelComfirmNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.labelNewPwd = new System.Windows.Forms.Label();
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
            this.delpanel.Controls.Add(this.txtConfirmPwd);
            this.delpanel.Controls.Add(this.labelComfirmNewPwd);
            this.delpanel.Controls.Add(this.txtNewPwd);
            this.delpanel.Controls.Add(this.labelNewPwd);
            this.delpanel.Location = new System.Drawing.Point(12, 12);
            this.delpanel.Name = "delpanel";
            this.delpanel.Size = new System.Drawing.Size(651, 383);
            this.delpanel.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 66);
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
            this.label1.Location = new System.Drawing.Point(90, 72);
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
            this.btnClose.Location = new System.Drawing.Point(433, 225);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 46);
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
            this.btnModify.Location = new System.Drawing.Point(433, 117);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(117, 46);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "提交修改";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(178, 125);
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
            this.labelOriginalPwd.Location = new System.Drawing.Point(90, 131);
            this.labelOriginalPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOriginalPwd.Name = "labelOriginalPwd";
            this.labelOriginalPwd.Size = new System.Drawing.Size(80, 18);
            this.labelOriginalPwd.TabIndex = 6;
            this.labelOriginalPwd.Text = "原密码：";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(178, 233);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(208, 28);
            this.txtConfirmPwd.TabIndex = 10;
            this.txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // labelComfirmNewPwd
            // 
            this.labelComfirmNewPwd.AutoSize = true;
            this.labelComfirmNewPwd.ForeColor = System.Drawing.Color.Red;
            this.labelComfirmNewPwd.Location = new System.Drawing.Point(72, 239);
            this.labelComfirmNewPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComfirmNewPwd.Name = "labelComfirmNewPwd";
            this.labelComfirmNewPwd.Size = new System.Drawing.Size(98, 18);
            this.labelComfirmNewPwd.TabIndex = 7;
            this.labelComfirmNewPwd.Text = "确认密码：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(176, 179);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(210, 28);
            this.txtNewPwd.TabIndex = 9;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // labelNewPwd
            // 
            this.labelNewPwd.AutoSize = true;
            this.labelNewPwd.ForeColor = System.Drawing.Color.Red;
            this.labelNewPwd.Location = new System.Drawing.Point(88, 185);
            this.labelNewPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPwd.Name = "labelNewPwd";
            this.labelNewPwd.Size = new System.Drawing.Size(80, 18);
            this.labelNewPwd.TabIndex = 8;
            this.labelNewPwd.Text = "新密码：";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 411);
            this.Controls.Add(this.delpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.delpanel.ResumeLayout(false);
            this.delpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel delpanel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label labelOriginalPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label labelComfirmNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label labelNewPwd;

    }
}