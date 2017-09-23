using System;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace EZLib
{
    public class Startup
    {
        public static void startupClient()
        {
            Form formControl = new formControl();

            formControl.ShowIcon = false;
            formControl.ShowInTaskbar = false;
            formControl.StartPosition = FormStartPosition.CenterScreen;

            UserControls.loginControl loginControl = new UserControls.loginControl();
            loginControl.Dock = DockStyle.Fill;

            formControl.Controls.Add(loginControl);

            formControl.ShowDialog();
        }
    }
}