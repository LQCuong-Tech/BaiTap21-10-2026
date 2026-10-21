using System;
using System.Windows.Forms;
using BaiTap4._6_4._7_4._8.Views;

namespace BaiTap4._6_4._7_4._8
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}