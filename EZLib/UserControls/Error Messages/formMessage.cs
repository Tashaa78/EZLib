using System;
using System.Windows.Forms;

namespace EZLib.UserControls.Error_Messages
{
    internal partial class formMessage : Form
    {
        public formMessage(string exceptionName, string exceptionMessage)
        {
            InitializeComponent();

            box_Error.Text = "Exception Name: " + exceptionName + "\r\n\r\nException Message: " + exceptionMessage;
        }

        private void button_Close_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
