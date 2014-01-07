using System;
using System.ServiceModel.Web;
using System.Windows.Forms;

namespace Website
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WebsiteMain());
            //Application.Run(new LoginForm());
        }
    }
}
