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
    public partial class JOpen : Form
    {
        public JOpen()
        {
            InitializeComponent();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            panelProgress.Width += 5;
            if(panelProgress.Width>=500)
            {
                timerProgress.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void panelProgress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
