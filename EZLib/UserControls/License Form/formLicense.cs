using System;
using System.Windows.Forms;

namespace EZLib.UserControls.License_Form
{
    public partial class formLicense : Form
    {
        public formLicense()
        {
            InitializeComponent();
        }

        private void formLicense_Load(object sender, EventArgs e)
        {
            form.Controls.Clear();
            form.Refresh();

            UserControls.licenseControl licenseControl = new UserControls.licenseControl();
            form.Controls.Add(licenseControl);

            form.Refresh();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
