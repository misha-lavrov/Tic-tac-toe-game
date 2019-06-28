using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Project
{
    class Program
    {
        static public MenuForm menu;
        static public GameForm game;
        static public AboutForm about;
        static public InfoForm info;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menu = new MenuForm();
            menu.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(menu);
        }
    }
}
