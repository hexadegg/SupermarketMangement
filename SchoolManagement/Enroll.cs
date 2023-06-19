using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRight.Text == "aaa")
            {
                Employee entry = new Employee();
                entry.Employee_ID = txtID.Text;
                entry.Employee_Email = textBox1.Text;
                entry.Keyword = txtpwd.Text;
                entry.Employee_Name = txtName.Text;
                if (radioButton1.Checked)
                    entry.Sex = "男";
                else entry.Sex = "女";
                db.Employee.Add(entry);//添加
                db.SaveChanges();
                MessageBox.Show("添加成功");
            }
            else MessageBox.Show("您无权限注册用户");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
