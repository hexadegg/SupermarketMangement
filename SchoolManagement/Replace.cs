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
    public partial class Replace : Form
    {  
        string name;
        public Replace()
        {
            InitializeComponent();
        }
        public Replace(string name)
        {
            this.name = name;
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
      
        private void mainPanel_Paint(object sender, PaintEventArgs e)
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
    }
}
