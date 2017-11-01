using System.Windows.Forms;
using EZLib;

namespace EZLibTests
{
    public partial class loginForm : Form
    {
        public static readonly EzLib EzLib = new EzLib();

        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            EzLib.Login(textUsername.Text, textPassword.Text);

            if (EzLib.LoginResponse())
            {
                MessageBox.Show("You have successfully logged in! I am now checking your license", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                EzLib.CheckLicense();

                if (EzLib.IsLicensedResponse())
                {
                    MessageBox.Show("Yay!");
                }
                else
                {
                    Hide();
                    using (var licenseForm = new licenseForm())
                    {
                        licenseForm.ShowDialog();
                    }
                }
            }   
            else
                MessageBox.Show(EzLib.LoginResponseReason());
        }

        private void buttonRegister_Click(object sender, System.EventArgs e)
        {
            Hide();
            using (var registerForm = new registerForm())
            {
                registerForm.ShowDialog();
            }
        }
    }
}