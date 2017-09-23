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
    }
}
