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
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1.准备参数 
            SqlParameter p1 = new SqlParameter("@UserEmail", SqlDbType.VarChar, 20);
            p1.Value = txtAccount.Text.Trim();
            p1.Direction = ParameterDirection.Input;

            SqlParameter p2 = new SqlParameter("@Password", SqlDbType.Char, 10);
            p2.Value = txtPwd.Text.Trim();
            p2.Direction = ParameterDirection.Input;

            SqlParameter p3 = new SqlParameter("", SqlDbType.Int);
            p3.Direction = ParameterDirection.ReturnValue;
            //2.执行存储过程
            List<SqlParameter> paraList = new List<SqlParameter>();
            paraList.Add(p1);
            paraList.Add(p2);
            paraList.Add(p3);

            DBHelper.ExecuteNonQuery("prcValidateUser", paraList, CommandType.StoredProcedure);
            //3.使用返回值或输出参数
            int n = (int)p3.Value;  //返回值
            if (n == 1)
            {
                MessageBox.Show("登录成功!");
                this.Hide();
                this.DialogResult = DialogResult.OK;
                MainWindow m = new MainWindow();
                m.getName(txtAccount.Text);
                if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
            else
                MessageBox.Show("登录失败!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logon mm = new Logon();
            try
            {
                using (Modify second = new Modify())
                {
                    mm.StartPosition = FormStartPosition.CenterScreen;
                    mm.FormBorderStyle = FormBorderStyle.None;
                    mm.Opacity = .70d;
                    mm.BackColor = Color.Black;
                    mm.Location = this.Location;
                    mm.ShowInTaskbar = false;
                    mm.Show();
                    second.Owner = mm;
                    second.StartPosition = FormStartPosition.CenterScreen;
                    second.ShowDialog();
                    mm.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mm.Dispose();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Logon_Load(object sender, EventArgs e)
        {

        }
    }
}
