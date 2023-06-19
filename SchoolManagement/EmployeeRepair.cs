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
    public partial class EmployeeRepair : Form
    {
        public EmployeeRepair()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void button4_Click(object sender, EventArgs e)
        {
            var result = from a in db.Indent select a;
            //员工编号
            if (this.txtID.Text != "")
            {
                result = from a in result
                         where a.Employee_ID == txtID.Text
                         select a;
            }
            if (this.txtEmail.Text != "")
            {
                result = from a in result
                         where a.Employee.Employee_Email == txtEmail.Text
                         select a;
            }
            //员工名称
            if (this.txtName.Text != "")
            {
                result = from a in result
                         where a.Employee.Employee_Name.Contains(txtName.Text)
                         select a;
            }

            var query = from a in result
                        select new { 员工编号 = a.Employee_ID, 员工名称 = a.Employee.Employee_Name, 订单编号 = a.Payment_ID, 订单日期 = a.Order_Date, 订单金额 = a.TotalOrder_Money };
            dataGridView2.DataSource = query.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = from p in db.Employee
                        select new { 编号 = p.Employee_ID, 姓名 = p.Employee_Name, 邮箱 = p.Employee_Email };
            dataGridView1.DataSource = query.ToList();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                    test second = new test();
                   
                    second.StartPosition = FormStartPosition.CenterScreen;
                    second.ShowDialog();
       
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("确认删除选中的员工?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    //获取主键
                    string employeeID = txtID.Text;
                    if (db.Indent.Count(b => b.Employee_ID == employeeID) > 0)
                    {
                        MessageBox.Show("该员工存在订单，不允许删除");
                        return;
                    }
                    //删除
                    {
                        Employee entry = db.Employee.SingleOrDefault(b => b.Employee_ID == employeeID);
                        db.Employee.Remove(entry);
                        db.SaveChanges();
                    }
                }

                button5.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee entry = new Employee();
            entry.Employee_Name = txtName.Text;
            entry.Employee_ID = txtID.Text;
            entry.Employee_Email = txtEmail.Text;
            db.Employee.Add(entry);
            db.SaveChanges();
            button5.PerformClick();
        }

        private void EmployeeRepair_Load(object sender, EventArgs e)
        {
            var query = from p in db.Employee
                        select new { 编号 = p.Employee_ID, 姓名 = p.Employee_Name, 邮箱 = p.Employee_Email };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string emgineerID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Employee entry = new Employee();
            entry = db.Employee.FirstOrDefault(a => a.Employee_ID == emgineerID); //查询
            txtName.Text = entry.Employee_Name;
            txtID.Text = entry.Employee_ID;
            txtEmail.Text = entry.Employee_Email;
        }
    }
}
