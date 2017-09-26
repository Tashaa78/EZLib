using System;
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace EZLib.UserControls
{
    internal partial class registerControl : UserControl
    {
        internal string currentCaptcha;

        public registerControl()
        {
            InitializeComponent();
        }

        private void registerControl_Load(object sender, EventArgs e)
        {
            string webResponse;
            string postData = "action=randomCaptcha";

            using (WebClient webClient = new WebClient())
            {
                webClient.Proxy = null;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "EZLib 1.0 +https://ezlib.rocks/");
                webResponse = webClient.DownloadString("http://localhost/Web_Server/api/endpoint.php?" + postData);

                currentCaptcha = webResponse;

                var image = new Bitmap(this.captcha.Width, this.captcha.Height);
                var font = new Font("Comic Sans", 25, FontStyle.Strikeout, GraphicsUnit.Pixel);
                var captcha = Graphics.FromImage(image);
                captcha.DrawString(webResponse, font, Brushes.Firebrick, new Point(0, 0));
                this.captcha.Image = image;
                this.captcha.Refresh();
            }
        }
    }
}
