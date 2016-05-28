using System;
using System.Windows.Forms;
using Alpha.Forms;
using Alpha.Utilities;

namespace Alpha
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

            string macAddress = "00C2C6529CB6";

            if (Security.ValidateComputer(macAddress))
                Application.Run(new MainForm());
            else
                MessageBox.Show("Please call 01228666814");
        }
    }
}