using System;
using System.Windows.Forms;

namespace EZLib.UserControls
{
    internal partial class licenseControl : UserControl
    {
        public licenseControl()
        {
            InitializeComponent();
        }

        private void button_License_Click(object sender, EventArgs e)
        {
            apiAccess.licenseUserApi(apiAccess.currentProgramId, box_Username.Text, box_License.Text);
        }
    }
}
