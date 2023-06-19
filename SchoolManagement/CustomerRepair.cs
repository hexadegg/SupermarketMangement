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
    public partial class CustomerRepair : Form
    {
        public CustomerRepair()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void CustomerRepair_Load(object sender, EventArgs e)
        {
            var query = from p in db.Customer
                        select new { 编号 = p.Customer_ID, 姓名 = p.Customer_Name, 性别 = p.Sex };
            dataGridView1.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = from a in db.Payment select a;
            //顾客编号
            if (this.txtID.Text != "")
            {
                result = from a in result
                         where a.Customer.Customer_ID == txtID.Text
                         select a;
            }
            //顾客名称
            if (this.txtName.Text != "")
            {
                result = from a in result
                         where a.Customer.Customer_Name.Contains(txtName.Text)
                         select a;
            }

            var query = from a in result
                        select new { 顾客编号 = a.Customer.Customer_ID, 顾客名称 = a.Customer.Customer_Name, 支付编号 = a.Payment_ID, 支付方式 = a.Payment_Method, 支付金额 = a.Payment_Money, 支付日期 = a.Payment_Time };
            dataGridView2.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer entry = db.Customer.FirstOrDefault(a => a.Customer_ID == txtID.Text); 
            entry.Customer_ID = txtID.Text;
            entry.Customer_Name = txtName.Text;
            db.SaveChanges();
            button5.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确认删除选中的客户?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                //获取主键
                string customerID = txtID.Text;
                if (db.Payment.Count(b => b.Customer_ID == customerID) > 0)
                {
                    MessageBox.Show("该客户存在订单，不允许删除");
                    return;
                }
                //删除
                {
                    Customer entry = db.Customer.SingleOrDefault(b => b.Customer_ID == customerID);
                    db.Customer.Remove(entry);
                    db.SaveChanges();
                }
            }
            button5.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = from p in db.Customer
                        select new { 编号 = p.Customer_ID, 姓名 = p.Customer_Name, 性别 = p.Sex };
            dataGridView1.DataSource = query.ToList();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer entry = new Customer();
            entry.Customer_ID = txtID.Text;
            entry.Customer_Name = txtName.Text;
            entry.Sex = "男";
            db.Customer.Add(entry);
            db.SaveChanges();
            button5.PerformClick();
        }
        int a;
        void getIndex(int a)
        {
            this.a = a;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Customer entry = new Customer();
            entry = db.Customer.FirstOrDefault(a => a.Customer_ID == customerID); //查询
            txtName.Text = entry.Customer_Name;
            txtID.Text = entry.Customer_ID;
            getIndex(e.RowIndex);
        }
    }
}
