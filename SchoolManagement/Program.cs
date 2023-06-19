using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            JOpen jo = new JOpen();
            if (jo.ShowDialog() == DialogResult.OK)
            {
                Logon l = new Logon();
                if (l.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainWindow());
                }
            }
            //Application.Run(new CategoryRepair());
        }
    }
}
