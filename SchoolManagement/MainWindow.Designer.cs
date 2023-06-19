namespace SchoolManagement
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收银ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCustemor = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnProCater = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProductRepair = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.paneldel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.paneldel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.收银ToolStripMenuItem,
            this.商品维护ToolStripMenuItem,
            this.客户信息维护ToolStripMenuItem,
            this.销售单ToolStripMenuItem,
            this.库存信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1527, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.首页ToolStripMenuItem.Text = "首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 收银ToolStripMenuItem
            // 
            this.收银ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.收银ToolStripMenuItem.Name = "收银ToolStripMenuItem";
            this.收银ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.收银ToolStripMenuItem.Text = "收银";
            this.收银ToolStripMenuItem.Click += new System.EventHandler(this.收银ToolStripMenuItem_Click);
            // 
            // 商品维护ToolStripMenuItem
            // 
            this.商品维护ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.商品维护ToolStripMenuItem.Name = "商品维护ToolStripMenuItem";
            this.商品维护ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品维护ToolStripMenuItem.Text = "商品维护";
            this.商品维护ToolStripMenuItem.Click += new System.EventHandler(this.商品维护ToolStripMenuItem_Click);
            // 
            // 客户信息维护ToolStripMenuItem
            // 
            this.客户信息维护ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.客户信息维护ToolStripMenuItem.Name = "客户信息维护ToolStripMenuItem";
            this.客户信息维护ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.客户信息维护ToolStripMenuItem.Text = "客户信息维护";
            this.客户信息维护ToolStripMenuItem.Click += new System.EventHandler(this.客户信息维护ToolStripMenuItem_Click);
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            this.销售单ToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.销售单ToolStripMenuItem.Text = "销售单";
            this.销售单ToolStripMenuItem.Click += new System.EventHandler(this.销售单ToolStripMenuItem_Click);
            // 
            // 库存信息ToolStripMenuItem
            // 
            this.库存信息ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.库存信息ToolStripMenuItem.Name = "库存信息ToolStripMenuItem";
            this.库存信息ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.库存信息ToolStripMenuItem.Text = "库存信息";
            this.库存信息ToolStripMenuItem.Click += new System.EventHandler(this.库存信息ToolStripMenuItem_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.btnExit);
            this.panelLeft.Controls.Add(this.btnInventory);
            this.panelLeft.Controls.Add(this.btnCustemor);
            this.panelLeft.Controls.Add(this.btnSale);
            this.panelLeft.Controls.Add(this.btnProCater);
            this.panelLeft.Controls.Add(this.btnEmployee);
            this.panelLeft.Controls.Add(this.btnProductRepair);
            this.panelLeft.Controls.Add(this.btnCash);
            this.panelLeft.Controls.Add(this.btnShow);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeft.Location = new System.Drawing.Point(0, 32);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(194, 828);
            this.panelLeft.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "商品进货";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            this.button1.Leave += new System.EventHandler(this.button1_Leave_1);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(-4, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 39);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "退出";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInventory.Location = new System.Drawing.Point(0, 289);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(194, 39);
            this.btnInventory.TabIndex = 16;
            this.btnInventory.Text = "商品库存查询";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button4_Click_1);
            this.btnInventory.Leave += new System.EventHandler(this.btnInventory_Leave);
            // 
            // btnCustemor
            // 
            this.btnCustemor.FlatAppearance.BorderSize = 0;
            this.btnCustemor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustemor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustemor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustemor.Location = new System.Drawing.Point(-4, 401);
            this.btnCustemor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustemor.Name = "btnCustemor";
            this.btnCustemor.Size = new System.Drawing.Size(194, 39);
            this.btnCustemor.TabIndex = 15;
            this.btnCustemor.Text = "客户信息维护";
            this.btnCustemor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustemor.UseVisualStyleBackColor = true;
            this.btnCustemor.Click += new System.EventHandler(this.button3_Click_1);
            this.btnCustemor.Leave += new System.EventHandler(this.btnCustemor_Leave);
            // 
            // btnSale
            // 
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSale.Location = new System.Drawing.Point(0, 356);
            this.btnSale.Margin = new System.Windows.Forms.Padding(4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(194, 39);
            this.btnSale.TabIndex = 14;
            this.btnSale.Text = "销售单查询";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.button2_Click_1);
            this.btnSale.Leave += new System.EventHandler(this.btnSale_Leave);
            // 
            // btnProCater
            // 
            this.btnProCater.FlatAppearance.BorderSize = 0;
            this.btnProCater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProCater.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProCater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProCater.Location = new System.Drawing.Point(0, 181);
            this.btnProCater.Margin = new System.Windows.Forms.Padding(4);
            this.btnProCater.Name = "btnProCater";
            this.btnProCater.Size = new System.Drawing.Size(194, 39);
            this.btnProCater.TabIndex = 16;
            this.btnProCater.Text = "商品类别维护";
            this.btnProCater.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProCater.UseVisualStyleBackColor = true;
            this.btnProCater.Click += new System.EventHandler(this.button11_Click);
            this.btnProCater.Leave += new System.EventHandler(this.btnProCater_Leave);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmployee.Location = new System.Drawing.Point(0, 463);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(194, 39);
            this.btnEmployee.TabIndex = 15;
            this.btnEmployee.Text = "员工个人信息维护";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            this.btnEmployee.Leave += new System.EventHandler(this.btnEmployee_Leave);
            // 
            // btnProductRepair
            // 
            this.btnProductRepair.FlatAppearance.BorderSize = 0;
            this.btnProductRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductRepair.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProductRepair.Location = new System.Drawing.Point(0, 134);
            this.btnProductRepair.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductRepair.Name = "btnProductRepair";
            this.btnProductRepair.Size = new System.Drawing.Size(194, 39);
            this.btnProductRepair.TabIndex = 13;
            this.btnProductRepair.Text = "商品信息维护";
            this.btnProductRepair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProductRepair.UseVisualStyleBackColor = true;
            this.btnProductRepair.Click += new System.EventHandler(this.button1_Click_1);
            this.btnProductRepair.Leave += new System.EventHandler(this.btnProductRepair_Leave);
            // 
            // btnCash
            // 
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCash.Location = new System.Drawing.Point(0, 87);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(194, 39);
            this.btnCash.TabIndex = 12;
            this.btnCash.Text = "收银页";
            this.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.button10_Click);
            this.btnCash.Leave += new System.EventHandler(this.btnCash_Leave);
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShow.Location = new System.Drawing.Point(0, 25);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(194, 39);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "首页";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnDashbord_Click);
            this.btnShow.Leave += new System.EventHandler(this.btnShow_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(62, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "欢迎使用银神之家超市管理系统";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(62, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(404, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "祝您有愉快的一天，请选择您需要的功能开始使用";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbName.Location = new System.Drawing.Point(57, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(164, 48);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label4";
            this.lbName.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(65, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 254);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "商品告急信息";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Honeydew;
            this.mainPanel.Controls.Add(this.paneldel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(194, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1333, 828);
            this.mainPanel.TabIndex = 11;
            // 
            // paneldel
            // 
            this.paneldel.Controls.Add(this.monthCalendar1);
            this.paneldel.Controls.Add(this.groupBox3);
            this.paneldel.Controls.Add(this.pictureBox1);
            this.paneldel.Controls.Add(this.groupBox2);
            this.paneldel.Controls.Add(this.label8);
            this.paneldel.Controls.Add(this.label5);
            this.paneldel.Controls.Add(this.lbName);
            this.paneldel.Location = new System.Drawing.Point(18, 44);
            this.paneldel.Name = "paneldel";
            this.paneldel.Size = new System.Drawing.Size(1258, 722);
            this.paneldel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.QQ图片20230506202804;
            this.pictureBox1.Location = new System.Drawing.Point(772, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 38);
            this.panel1.TabIndex = 13;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(65, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "裁员信息";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(784, 441);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(79, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "编号EE00009的员工还未工作，请尽快动身！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(79, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "编号EE00008的员工还未工作，请尽快动身！";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "编号EE00007的员工还未工作，请尽快动身！";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.paneldel.ResumeLayout(false);
            this.paneldel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收银ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存信息ToolStripMenuItem;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel paneldel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnProductRepair;
        private System.Windows.Forms.Button btnProCater;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCustemor;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}