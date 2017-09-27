using System.Windows.Forms;

namespace EZLibTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EZLib.Startup.authProgram("0DCKDWOTF");
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            label1.Text = "Your Username: " + EZLib.UserInformation.userUsername();
            label2.Text = "License Key: " + EZLib.UserInformation.userLicense();
            label4.Text = "License Expiration Date: " + EZLib.UserInformation.licenseExpiryDate();
        }
    }
}
