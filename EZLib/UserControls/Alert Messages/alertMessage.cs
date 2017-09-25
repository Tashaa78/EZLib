using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib.UserControls.Alert_Messages
{
    internal partial class alertMessage : UserControl
    {
        public alertMessage(string message, string type)
        {
            InitializeComponent();

            label_Message.Text = message;
            switch (type)
            {
                case "success":
                    this.BackColor = Color.SeaGreen;
                    break;
                case "error":
                    this.BackColor = Color.Firebrick;
                    break;
                case "information":
                    this.BackColor = Color.SkyBlue;
                    break;
                case "warning":
                    this.BackColor = Color.DarkOrange;
                    break;
            }
        }

        private void alertMessage_Load(object sender, EventArgs e)
        {
            this.Top = 70;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }
    }
}
