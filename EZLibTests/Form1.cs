using System.Windows.Forms;

namespace EZLibTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EZLib.Startup.authProgram("5994393");
        }
    }
}
