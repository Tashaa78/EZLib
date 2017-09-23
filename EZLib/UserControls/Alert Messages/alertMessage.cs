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
        public alertMessage(string message, AlertType type)
        {
            InitializeComponent();

            label_Message.Text = message;
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.error:
                    this.BackColor = Color.Firebrick;
                    break;
                case AlertType.information:
                    this.BackColor = Color.SkyBlue;
                    break;
                case AlertType.warning:
                    this.BackColor = Color.DarkOrange;
                    break;
            }
        }

        public enum AlertType
        {
            success, information, error, warning
        }

        private void alertMessage_Load(object sender, EventArgs e)
        {
            this.Top = 70;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }
    }
}
