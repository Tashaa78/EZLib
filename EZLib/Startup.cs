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
            using (Form formClient = new Form())
            {
                formClient.Text = "EZLib";
                formClient.ShowIcon = false;
                formClient.ShowInTaskbar = false;
                formClient.Size = new Size(442, 270);
                formClient.FormBorderStyle = FormBorderStyle.None;

                EZLib.UserControls.loginControl loginControl = new UserControls.loginControl();

                formClient.Controls.Add(loginControl);

                formClient.ShowDialog();
            }
        }
    }
}