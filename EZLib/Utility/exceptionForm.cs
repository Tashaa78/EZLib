using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib.Utility
{
    public partial class exceptionForm : Form
    {
        public exceptionForm(string exceptionName, string exceptionSimpleDescription, string exceptionDescription)
        {
            InitializeComponent();
            textException.Text = $"[Exception Name: {exceptionName}]\r\n\r\n{exceptionSimpleDescription}\r\n\r\n{exceptionDescription}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
