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
    public partial class licenseControl : UserControl
    {
        public licenseControl()
        {
            InitializeComponent();
        }

        private void button_License_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Licensed");
        }
    }
}
