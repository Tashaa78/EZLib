using System;
using System.Windows.Forms;
using EZLib;

namespace EZLibTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var EZLib = new EZLib.EZLib();
            var ResponseI = new Response().InitializeResponse();

            ResponseI = EZLib.Initialize("d7e28501");

            if (ResponseI)
            {
                // Show login form
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}