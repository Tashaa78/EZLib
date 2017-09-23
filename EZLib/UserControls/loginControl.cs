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
            apiAccess.registerApi(box_Username.Text, box_Password.Text);
        }

        private void loginControl_Load(object sender, EventArgs e)
        {

        }
    }
}
