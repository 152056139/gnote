using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace form
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
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            if (fl.DialogResult == DialogResult.Cancel)
            {
                Application.Run(new FormMain());
            }
            else
            {
                return;
            }
                
            
        }
    }
}
