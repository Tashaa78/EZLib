using System;
using System.Windows.Forms;
using EZLib;

namespace EZLibTests
{
    public partial class licenseForm : Form
    {
        public static readonly EzLib EzLib = new EzLib();

        public licenseForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textLicense.Text == "")
            {
                MessageBox.Show("All fields are required!", "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EzLib.RegisterLicense(textLicense.Text);

                if (EzLib.IsLicensedResponse())
                {
                    MessageBox.Show("LOL");
                }
                else
                {
                    MessageBox.Show(EzLib.LicenseResponseReason());
                }
            }
        }

        private void licenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
