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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
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
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            loadform(new Logon());
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
    
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            loadform(new Enroll());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            loadform(new Modify());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void delpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
