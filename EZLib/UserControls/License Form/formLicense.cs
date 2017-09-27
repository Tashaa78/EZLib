using System;
using System.Windows.Forms;

namespace EZLib.UserControls.License_Form
{
    internal partial class formLicense : Form
    {
        public formLicense()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void formLicense_Load(object sender, EventArgs e)
        {
            form.Controls.Clear();
            form.Refresh();

            UserControls.licenseControl licenseControl = new UserControls.licenseControl();
            form.Controls.Add(licenseControl);

            form.Refresh();
        }
    }
}
