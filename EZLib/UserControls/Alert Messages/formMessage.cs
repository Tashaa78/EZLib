using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib.UserControls.Alert_Messages
{
    public partial class formMessage : Form
    {
        public formMessage()
        {
            InitializeComponent();
        }

        private void load_time_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 1;
            } else
            {
                this.Close();
            }
        }

        private void formMessage_Load(object sender, EventArgs e)
        {
            load_time.Start();
        }
    }
}
