namespace SchoolManagement
{
    partial class JOpen
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
            this.components = new System.ComponentModel.Container();
            this.panelProgressBar = new System.Windows.Forms.Panel();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.panelProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(193)))));
            this.panelProgressBar.Controls.Add(this.panelProgress);
            this.panelProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressBar.Location = new System.Drawing.Point(0, 359);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(500, 141);
            this.panelProgressBar.TabIndex = 1;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelProgress.Location = new System.Drawing.Point(0, 0);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(33, 141);
            this.panelProgress.TabIndex = 2;
            this.panelProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProgress_Paint);
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 30;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // JOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.QQ图片20230506202804;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panelProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JOpen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOpen";
            this.panelProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProgressBar;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Timer timerProgress;
    }
}