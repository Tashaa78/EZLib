using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib
{
    internal partial class mainControl : Form
    {
        public mainControl()
        {
            InitializeComponent();
        }

        void currentTab(object sender)
        {
            tab_selected.Top = ((Control)sender).Top;
            tab_selected.Height = ((Control)sender).Height;
        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            currentTab(sender);
            form.Controls.Clear();
            form.Refresh();

            UserControls.loginControl loginControl = new UserControls.loginControl();
            form.Controls.Add(loginControl);

            form.Refresh();
        }

        private void button_sign_up_Click(object sender, EventArgs e)
        {
            currentTab(sender);
            form.Controls.Clear();
            form.Refresh();

            UserControls.registerControl registerControl = new UserControls.registerControl();
            form.Controls.Add(registerControl);

            form.Refresh();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_news_Click(object sender, EventArgs e)
        {
            currentTab(sender);
            form.Controls.Clear();
            form.Refresh();
        }
    }
}
