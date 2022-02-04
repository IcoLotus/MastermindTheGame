using System;
using System.Windows.Forms;

namespace mastermind_pre_2_0
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
            Application.Run(new mastermind_pre_2());
        }
    }
}
