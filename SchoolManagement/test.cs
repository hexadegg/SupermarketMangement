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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void test_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Employee entry;
            entry = db.Employee.FirstOrDefault(a => a.Employee_Email == txtEmail.Text); //查询
            if (txtNewPwd.Text == txtConfirmPwd.Text)
            {
                entry.Keyword = txtNewPwd.Text;
            }
            db.SaveChanges();//保存修改
            MessageBox.Show("修改成功");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
