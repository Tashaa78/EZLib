using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib.UserControls
{
    internal partial class loginControl : UserControl
    {
        public loginControl()
        {
            InitializeComponent();
        }

        private void button_Close_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (box_Username.Text == "" || box_Password.Text == "")
            {
                Form formControl = new UserControls.Alert_Messages.formMessage();

                formControl.StartPosition = FormStartPosition.Manual;
                formControl.ShowIcon = false;
                formControl.ShowInTaskbar = false;
                formControl.Opacity = 95;
                formControl.Top = 60;
                formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                UserControls.Alert_Messages.alertMessage r_alertMessage = new UserControls.Alert_Messages.alertMessage("Username and Password fields are required", UserControls.Alert_Messages.alertMessage.AlertType.information);
                r_alertMessage.Dock = DockStyle.Fill;

                formControl.Controls.Add(r_alertMessage);

                formControl.ShowDialog();
            } else
            {
                apiAccess.loginApi(box_Username.Text, box_Password.Text);
            }
        }
    }
}
