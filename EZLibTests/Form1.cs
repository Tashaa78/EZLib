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
            label1.Text = EZLib.UserInformation.licenseExpiryDate();
        }
    }
}
