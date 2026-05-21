using LibraryManagementSystem.UI;
using LibraryManagementSystem.UI.Mainpage;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        
    }
}
