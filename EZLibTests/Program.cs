using System;
using System.Windows.Forms;
using EZLib;

namespace EZLibTests
{
    internal static class Program
    {
        public static readonly EzLib EzLib = new EzLib();

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EzLib.Initialize("1260450652");

            if (EzLib.InitializeResponse())
            {
                Application.Run(new loginForm());
            }
            else
            {
                MessageBox.Show(EzLib.InitializeResponseReason());
            }
        }
    }
}