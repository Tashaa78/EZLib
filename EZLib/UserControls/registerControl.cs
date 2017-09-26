using System;
using System.Drawing;
using System.Windows.Forms;

namespace EZLib.UserControls
{
    internal partial class registerControl : UserControl
    {
        public registerControl()
        {
            InitializeComponent();
        }

        private void registerControl_Load(object sender, EventArgs e)
        {
            var image = new Bitmap(this.captcha.Width, this.captcha.Height);
            var font = new Font("Comic Sans MS", 25, FontStyle.Strikeout, GraphicsUnit.Pixel);
            var captcha = Graphics.FromImage(image);
            captcha.DrawString(apiAccess.randomCaptchaApi(), font, Brushes.SkyBlue, new Point(0, 0));
            this.captcha.Image = image;
            this.captcha.Refresh();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (box_Username.Text == "" || box_Password.Text == "" || box_captcha.Text == "")
            {
                apiAccess.messageHandler("All fields are required", "warning");
            }
            else
            {
                if (box_captcha.Text == apiAccess.currentCaptcha)
                {
                    apiAccess.registerApi(box_Username.Text, box_Password.Text);
                } else
                {
                    apiAccess.messageHandler("Captcha does not match", "warning");
                }
            }
        }
    }
}
