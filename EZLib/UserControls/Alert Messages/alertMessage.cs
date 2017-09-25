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
        public alertMessage()
        {
            InitializeComponent();
        }

        public void message(string message, string type)
        {
            label_Message.Text = message;

            if (type == "success")
            {
                this.BackColor = Color.SeaGreen;
            }
            else if (type == "error")
            {
                this.BackColor = Color.Firebrick;
            }
            else if (type == "information")
            {
                this.BackColor = Color.SkyBlue;
            }
            else if (type == "warning")
            {
                this.BackColor = Color.DarkOrange;
            }
        }
    }
}
