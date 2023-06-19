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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void delpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哈哈，这个我还不会^^-^^");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
