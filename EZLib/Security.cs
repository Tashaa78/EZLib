using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace EZLib
{
    public class Security
    {
        public static void validateEZLib()
        {
            string fileName = "EZLib.dll";
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] retVal = sha1.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }

            string webResponse;
            string apiUrl = "https://ezlib.rocks/api/endpoint.php?action=checksum&dllHash=" + sb.ToString();

            using (WebClient webClient = new WebClient())
            {
                webClient.Proxy = null;
                webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                webResponse = webClient.DownloadString(apiUrl);

                if (webResponse.Contains("success"))
                {
                    MessageBox.Show(webResponse);
                }
                else
                {
                    errorHash();
                }
            }
        }

        #region errorMessages
        private static void errorHash()
        {
            using (Form form = new Form())
            {
                form.Text = "EZLib";
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Width = 384;
                form.Height = 180;
                form.ShowIcon = false;
                form.ShowInTaskbar = false;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.StartPosition = FormStartPosition.CenterScreen;

                Label EZLibLabel = new Label();
                EZLibLabel.Text = "EZLib";
                EZLibLabel.Width = 70;
                EZLibLabel.Height = 25;
                EZLibLabel.Font = new Font("Lucida Console", 14);
                EZLibLabel.Location = new Point(134, 9);

                Label ErrorLabel = new Label();
                ErrorLabel.Text = "This EZLib is either deprecated or tampered.";
                ErrorLabel.Width = 400;
                ErrorLabel.Height = 11;
                ErrorLabel.Font = new Font("Lucida Console", 8);
                ErrorLabel.Location = new Point(10, 53);

                Label ErrorCodeLabel = new Label();
                ErrorCodeLabel.Text = "Error Code: 0x100S";
                ErrorCodeLabel.Width = 300;
                ErrorCodeLabel.Height = 11;
                ErrorCodeLabel.ForeColor = Color.Firebrick;
                ErrorCodeLabel.Font = new Font("Lucida Console", 8);
                ErrorCodeLabel.Location = new Point(10, 74);

                Button ButtonOK = new Button();
                ButtonOK.Text = "OK";
                ButtonOK.Font = new Font("Lucida Console", 8);
                ButtonOK.Size = new Size(75, 32);
                ButtonOK.Location = new Point(129, 99);

                form.Controls.Add(EZLibLabel);
                form.Controls.Add(ErrorLabel);
                form.Controls.Add(ErrorCodeLabel);
                form.Controls.Add(ButtonOK);

                ButtonOK.Click += new EventHandler(buttonOK);
                form.FormClosing += new FormClosingEventHandler(formClosing);


                #region Events
                void formClosing(object sender, FormClosingEventArgs e)
                {
                    Environment.Exit(0);
                }


                void buttonOK(object sender, EventArgs e)
                {
                    Environment.Exit(0);
                }
                #endregion

                form.ShowDialog();
            }
            #endregion
        }
    }
}