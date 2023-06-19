namespace SchoolManagement
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.delpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.delpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnEnroll);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 776);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Honeydew;
            this.mainPanel.Controls.Add(this.delpanel);
            this.mainPanel.Location = new System.Drawing.Point(192, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1046, 776);
            this.mainPanel.TabIndex = 9;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // delpanel
            // 
            this.delpanel.Controls.Add(this.label4);
            this.delpanel.Controls.Add(this.monthCalendarMain);
            this.delpanel.Controls.Add(this.label5);
            this.delpanel.Controls.Add(this.groupBox1);
            this.delpanel.Controls.Add(this.pictureBox1);
            this.delpanel.Location = new System.Drawing.Point(40, 27);
            this.delpanel.Name = "delpanel";
            this.delpanel.Size = new System.Drawing.Size(966, 671);
            this.delpanel.TabIndex = 11;
            this.delpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.delpanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(596, 48);
            this.label4.TabIndex = 0;
            this.label4.Text = "欢迎使用超级无敌开挂系统";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.Location = new System.Drawing.Point(643, 360);
            this.monthCalendarMain.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.TabIndex = 9;
            this.monthCalendarMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(644, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "请选择您需要的功能开始使用";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(76, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告列表";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.QQ图片20230506202757;
            this.pictureBox1.Location = new System.Drawing.Point(765, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SchoolManagement.Properties.Resources.icon_登录1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-22, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "     退出系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Image = global::SchoolManagement.Properties.Resources.用户3;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(-3, 434);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(220, 49);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "密码修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnroll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.Image = global::SchoolManagement.Properties.Resources.用户3;
            this.btnEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnroll.Location = new System.Drawing.Point(-5, 348);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(220, 49);
            this.btnEnroll.TabIndex = 10;
            this.btnEnroll.Text = "用户注册";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Image = global::SchoolManagement.Properties.Resources.用户3;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(-5, 265);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(220, 49);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "员工登录";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 776);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "超市管理系统-登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.delpanel.ResumeLayout(false);
            this.delpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.Panel delpanel;
        private System.Windows.Forms.Button button1;
    }
}