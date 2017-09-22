using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLibTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EZLib.Startup.authenticateProgram("SuiHtcU04q");
            MessageBox.Show(EZLib.UserInformation.currentLicense());
        }
    }
}
