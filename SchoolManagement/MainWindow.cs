using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainWindow : Form
    {
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        public MainWindow()
        {
            InitializeComponent();
        }
        //解决winform窗体控件多，加载慢、卡顿的问题
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }

        //利用panel实现页面的切换
        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        string name;
        public void getName(string name)
        {
            this.name = name;
        }



        private void MainWindow_Load(object sender, EventArgs e)
        {
            var entry = db.Employee.FirstOrDefault(a => a.Employee_Email == name);
            string NAME = entry.Employee_Name;
            lbName.Text = NAME;
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour >= 0 && hour < 12)
            {
                lbName.Text += "，早上好！";
            }
            else if (hour >= 12 && hour < 18)
            {
                lbName.Text += "，中午好！";
            }
            else
            {
                lbName.Text += "，晚上好！";
            }
            int c = 0;
            var query = from p in db.Product
                        where p.Inventory.Quantity < p.Inventory.Threshold
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 库存 = p.Inventory.Quantity, 阈值 = p.Inventory.Threshold };
            foreach (var item in query)
            {
                Label l = new Label();
                string a = item.商品编号;
                string b = item.商品名称;

                l.Text = "商品编号:" + a + "  商品名称:" + b;
                l.AutoSize = true;
                l.ForeColor = System.Drawing.Color.Red;
                l.Location = new System.Drawing.Point(35, 50 + c);
                l.Name = a;
                l.Size = new System.Drawing.Size(314, 18);

                this.groupBox3.Controls.Add(l);
                c += 20; // 在每次循环结束后增加垂直位置，按每行高度来设置
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void 收银ToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            // CashDesk cd;
            //mainPanel.Hide();
            //cd = new CashDesk();
            //cd.MdiParent = this;
            //if (cd.ShowDialog() == DialogResult.OK)
            //{
            //    mainPanel.Show();
            //}
            loadform(new CashDesk());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private Point point;

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point (e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myposition = MousePosition;
                myposition.Offset(-point.X, -point.Y);
                this.DesktopLocation = myposition;
            }
        }

        private void 商品维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ProductRepair());
        }

        private void 客户信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);

            }

            CustomerRepair cr = new CustomerRepair();
            cr.MdiParent = this;
            cr.Show();
        }

        private void 销售单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new SaleQuery());
        }

        private void 库存信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new InventryQUery());
        }

        private void button8_Click(object sender, EventArgs e)
        {
    
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Replace(name));
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            btnProductRepair.BackColor=Color.FromArgb(24, 30, 54);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnCash.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new CashDesk());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnProductRepair.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new ProductRepair());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btnProCater.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new CategoryRepair());
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new SaleQuery());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btnCustemor.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new CustomerRepair());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new InventryQUery());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new Replace(name));
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new EmployeeRepair());
        }

        private void btnShow_Leave(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCash_Leave(object sender, EventArgs e)
        {
            btnCash.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProductRepair_Leave(object sender, EventArgs e)
        {
            btnProductRepair.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProCater_Leave(object sender, EventArgs e)
        {
            btnProCater.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmployee_Leave(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSale_Leave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustemor_Leave(object sender, EventArgs e)
        {
            btnCustemor.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnInventory_Leave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myposition = MousePosition;
                myposition.Offset(-point.X, -point.Y);
                this.DesktopLocation = myposition;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            loadform(new ProductRestock());
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Leave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
        
    }
}
