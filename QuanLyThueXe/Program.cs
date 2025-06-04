using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyThueXe.GUI;
using System.Windows.Forms;

namespace QuanLyThueXe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI_MainForm());
            Application.Run(new GUI_LoginForm());
        }
    }
}
