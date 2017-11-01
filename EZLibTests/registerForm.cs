using System;
using System.Windows.Forms;
using EZLib;

namespace EZLibTests
{
    public partial class registerForm : Form
    {
        public static readonly EzLib EzLib = new EzLib();

        public registerForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            using (var loginForm = new loginForm())
            {
                loginForm.ShowDialog();
            }
        }

        private void registerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textFName.Text == "" || textLName.Text == "" || textEmail.Text == "" || textUsername.Text == "" ||
                textPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EzLib.Register(textFName.Text, textLName.Text, textEmail.Text, textUsername.Text, textPassword.Text);

                if (EzLib.RegisterResponse())
                {
                    Hide();
                    using (var loginForm = new loginForm())
                    {
                        loginForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(EzLib.RegisterResponseReason());
                }
            }
        }
    }
}