using System;
using System.Windows.Forms;

namespace EZLib.UserControls
{
    internal partial class loaderControl : UserControl
    {
        public loaderControl()
        {
            InitializeComponent();
        }

        private void loaderControl_Load(object sender, EventArgs e)
        {
            load_time.Start();
        }

        private void load_time_Tick(object sender, EventArgs e)
        {
            if (load_time.Interval < 3000)
            {
                load_time.Interval++;
            } else
            {
                apiAccess.loaderForm.Close();
            }
        }
    }
}
