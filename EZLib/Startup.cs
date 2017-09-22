using System;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace EZLib
{
    public class Startup
    {
        private static string username;
        private static string globalProgramId;

        public static void authenticateProgram(string programId)
        {
            string webResponse;
            string apiUrl = "https://ezlib.rocks/api/endpoint.php?action=authenticateProgram&programId=" + programId;

            using (WebClient webClient = new WebClient())
            {
                webClient.Proxy = null;
                webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                webResponse = webClient.DownloadString(apiUrl);

                if (webResponse.Contains("programName"))
                {
                    globalProgramId = programId;
                    startupClient();
                }
                else
                {
                    errorMsgProgram();
                }
            }
        }

        private static void startupClient()
        {
            using (Form form = new Form())
            {
                form.Text = "EZLib";
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Width = 263;
                form.Height = 292;
                form.ShowIcon = false;
                form.ShowInTaskbar = false;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.StartPosition = FormStartPosition.CenterScreen;

                Label ezlibLabel = new Label();
                ezlibLabel.Text = "EZLib";
                ezlibLabel.Width = 70;
                ezlibLabel.Height = 25;
                ezlibLabel.Font = new Font("Lucida Console", 14);
                ezlibLabel.Location = new Point(91, 21);

                Label usernameLabel = new Label();
                usernameLabel.Text = "Username";
                usernameLabel.Width = 70;
                usernameLabel.Height = 12;
                usernameLabel.Font = new Font("Lucida Console", 8);
                usernameLabel.Location = new Point(12, 78);

                TextBox usernameText = new TextBox();
                usernameText.Size = new Size(219, 20);
                usernameText.Location = new Point(14, 92);

                Label passwordLabel = new Label();
                passwordLabel.Text = "Password";
                passwordLabel.Width = 70;
                passwordLabel.Height = 12;
                passwordLabel.Font = new Font("Lucida Console", 8);
                passwordLabel.Location = new Point(12, 117);

                TextBox passwordText = new TextBox();
                passwordText.Size = new Size(219, 20);
                passwordText.Location = new Point(14, 131);
                passwordText.UseSystemPasswordChar = true;

                Button ButtonLogin = new Button();
                ButtonLogin.Text = "Login";
                ButtonLogin.Font = new Font("Lucida Console", 8);
                ButtonLogin.Size = new Size(219, 20);
                ButtonLogin.Location = new Point(14, 168);

                Button ButtonRegister = new Button();
                ButtonRegister.Text = "Register";
                ButtonRegister.Font = new Font("Lucida Console", 8);
                ButtonRegister.Size = new Size(219, 20);
                ButtonRegister.Location = new Point(14, 197);

                Label copyrightLabel = new Label();
                copyrightLabel.Text = "Copyright 2017 EZLib";
                copyrightLabel.Width = 2000;
                copyrightLabel.Height = 12;
                copyrightLabel.Font = new Font("Lucida Console", 8);
                copyrightLabel.Location = new Point(51, 234);

                form.Controls.Add(ezlibLabel);
                form.Controls.Add(usernameLabel);
                form.Controls.Add(usernameText);
                form.Controls.Add(passwordLabel);
                form.Controls.Add(passwordText);
                form.Controls.Add(ButtonLogin);
                form.Controls.Add(ButtonRegister);
                form.Controls.Add(copyrightLabel);

                ButtonLogin.Click += new EventHandler(buttonLogin);
                ButtonRegister.Click += new EventHandler(buttonRegister);
                form.FormClosing += new FormClosingEventHandler(formClosing);


                void buttonLogin(object sender, EventArgs e)
                {
                    if (usernameText.Text == "" || passwordText.Text == "")
                    {
                        MessageBox.Show("Username and Password fields required", "EZLib — Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string webResponse;
                        string apiUrl = "https://ezlib.rocks/api/endpoint.php?action=authenticate&username=" + usernameText.Text + "&password=" + passwordText.Text + "&hardware_id=" + Hardware_ID.Generate();

                        using (WebClient webClient = new WebClient())
                        {
                            webClient.Proxy = null;
                            webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                            webResponse = webClient.DownloadString(apiUrl);

                            if (webResponse.Contains("success"))
                            {
                                username = usernameText.Text;

                                string apiUrl2 = "https://ezlib.rocks/api/endpoint.php?action=isLicensed&programId=" + globalProgramId + "&username=" + username;

                                using (WebClient webClient2 = new WebClient())
                                {
                                    webClient.Proxy = null;
                                    webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                                    webResponse = webClient.DownloadString(apiUrl2);

                                    if (webResponse.Contains("success"))
                                    {
                                        form.Hide();
                                        loadingScreen();
                                    } else
                                    {
                                        // Show License panel (TODO)
                                    }
                                }
                            } else if (webResponse.Contains("Hardware"))
                            {
                                errorhwidDM();
                            } else if (webResponse.Contains("Password"))
                            {
                                // Incorrect password (TODO)
                            }
                            else if (webResponse.Contains("exist"))
                            {
                                // Account does not exist (TODO)
                            }
                        }
                    }
                }

                string captcha;

                #region Events
                void buttonRegister(object sender, EventArgs e)
                {
                    using (Form registerForm = new Form())
                    {
                        registerForm.Text = "EZLib";
                        registerForm.MaximizeBox = false;
                        registerForm.MinimizeBox = false;
                        registerForm.Width = 263;
                        registerForm.Height = 338;
                        registerForm.ShowIcon = false;
                        registerForm.ShowInTaskbar = false;
                        registerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        registerForm.StartPosition = FormStartPosition.CenterScreen;

                        Label REZLibLabel = new Label();
                        REZLibLabel.Text = "EZLib";
                        REZLibLabel.Width = 70;
                        REZLibLabel.Height = 25;
                        REZLibLabel.Font = new Font("Lucida Console", 14);
                        REZLibLabel.Location = new Point(91, 21);

                        Label RUsernameLabel = new Label();
                        RUsernameLabel.Text = "Username";
                        RUsernameLabel.Width = 70;
                        RUsernameLabel.Height = 12;
                        RUsernameLabel.Font = new Font("Lucida Console", 8);
                        RUsernameLabel.Location = new Point(12, 78);

                        TextBox RUsernameText = new TextBox();
                        RUsernameText.Size = new Size(219, 20);
                        RUsernameText.Location = new Point(14, 92);

                        Label RPasswordLabel = new Label();
                        RPasswordLabel.Text = "Password";
                        RPasswordLabel.Width = 70;
                        RPasswordLabel.Height = 12;
                        RPasswordLabel.Font = new Font("Lucida Console", 8);
                        RPasswordLabel.Location = new Point(12, 117);

                        TextBox RPasswordText = new TextBox();
                        RPasswordText.Size = new Size(219, 20);
                        RPasswordText.Location = new Point(14, 131);
                        RPasswordText.UseSystemPasswordChar = true;

                        Label RCaptchaLabel = new Label();
                        RCaptchaLabel.Text = "Captcha";
                        RCaptchaLabel.Width = 70;
                        RCaptchaLabel.Height = 12;
                        RCaptchaLabel.Font = new Font("Lucida Console", 8);
                        RCaptchaLabel.Location = new Point(12, 152);

                        PictureBox RPictureBox = new PictureBox();
                        RPictureBox.Size = new Size(219, 20);
                        RPictureBox.Location = new Point(14, 166);

                        TextBox RCaptchaText = new TextBox();
                        RCaptchaText.Size = new Size(219, 20);
                        RCaptchaText.Location = new Point(14, 236);

                        Button RRegisterButton = new Button();
                        RRegisterButton.Size = new Size(98, 31);
                        RRegisterButton.Font = new Font("Lucida Console", 8);
                        RRegisterButton.Text = "Register";
                        RRegisterButton.Location = new Point(135, 262);

                        void randomCaptcha()
                        {
                            Random random = new Random();
                            captcha = Guid.NewGuid().ToString().Substring(0, 9).Replace("-", "");
                            var image = new Bitmap(RPictureBox.Width, RPictureBox.Height);
                            var font = new Font("Comic Sans MS", 16, FontStyle.Bold, GraphicsUnit.Pixel);
                            var graphics = Graphics.FromImage(image);
                            graphics.DrawString(captcha.ToString(), font, Brushes.DimGray, new Point(60, 0));
                            RPictureBox.Image = image;
                        }

                        randomCaptcha();

                        registerForm.Controls.Add(REZLibLabel);
                        registerForm.Controls.Add(RUsernameLabel);
                        registerForm.Controls.Add(RUsernameText);
                        registerForm.Controls.Add(RPasswordLabel);
                        registerForm.Controls.Add(RPasswordText);
                        registerForm.Controls.Add(RCaptchaLabel);
                        registerForm.Controls.Add(RPictureBox);
                        registerForm.Controls.Add(RCaptchaText);
                        registerForm.Controls.Add(RRegisterButton);

                        RRegisterButton.Click += new EventHandler(buttonRRegister);
                        registerForm.FormClosing += new FormClosingEventHandler(formClosing);

                        void buttonRRegister(object Rsender, EventArgs Re)
                        {
                            if (RUsernameText.Text == "" || RPasswordText.Text == "" || RCaptchaText.Text == "")
                            {
                                MessageBox.Show("Username, Password, and Captcha fields required", "EZLib — Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            } else if (RCaptchaText.Text == captcha.ToString())
                            {
                                string webResponse;
                                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                                string apiUrl = "https://ezlib.rocks/api/endpoint.php?action=register&username=" + RUsernameText.Text + "&password=" + RPasswordText.Text + "&ip_address=" + externalip + "&hardware_id=" + Hardware_ID.Generate();

                                using (WebClient webClient = new WebClient())
                                {
                                    webClient.Proxy = null;
                                    webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                                    webResponse = webClient.DownloadString(apiUrl);

                                    if (webResponse.Contains("success"))
                                    {
                                        MessageBox.Show("You have successfully registered", "EZLib — Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        registerForm.Hide();
                                        form.Visible = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your username could be taken or you have already registed once already", "EZLib — Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }

                            } else
                            {
                                MessageBox.Show("Captcha is incorrect", "EZLib — Incorrect Captcha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                randomCaptcha();
                                RPictureBox.Refresh();
                            }
                        }

                        form.Visible = false;
                        registerForm.ShowDialog();
                    }

                }

                
                void formClosing(object sender, FormClosingEventArgs e)
                {
                    if (e.CloseReason == CloseReason.UserClosing)
                    {
                        DialogResult result = MessageBox.Show("Do you really want close this form?", "EZLib", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
#endregion

                form.ShowDialog();
            }
        }

        #region Messages

        private static void errorMsgProgram()
        {
            using (Form form = new Form())
            {
                form.Text = "EZLib";
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Width = 317;
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
                EZLibLabel.Location = new Point(118, 9);

                Label ErrorLabel = new Label();
                ErrorLabel.Text = "This program ID is incorrect or banned.";
                ErrorLabel.Width = 278;
                ErrorLabel.Height = 11;
                ErrorLabel.Font = new Font("Lucida Console", 8);
                ErrorLabel.Location = new Point(11, 53);

                Label ErrorCodeLabel = new Label();
                ErrorCodeLabel.Text = "Error Code: 0x10S";
                ErrorCodeLabel.Width = 124;
                ErrorCodeLabel.Height = 11;
                ErrorCodeLabel.ForeColor = Color.Firebrick;
                ErrorCodeLabel.Font = new Font("Lucida Console", 8);
                ErrorCodeLabel.Location = new Point(11, 78);

                Button ButtonOK = new Button();
                ButtonOK.Text = "OK";
                ButtonOK.Font = new Font("Lucida Console", 8);
                ButtonOK.Size = new Size(75, 32);
                ButtonOK.Location = new Point(113, 104);

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
        }
        private static void errorhwidDM()
        {
            using (Form form = new Form())
            {
                form.Text = "EZLib";
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Width = 336;
                form.Height = 196;
                form.ShowIcon = false;
                form.ShowInTaskbar = false;
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.StartPosition = FormStartPosition.CenterScreen;

                Label EZLibLabel = new Label();
                EZLibLabel.Text = "EZLib";
                EZLibLabel.Width = 70;
                EZLibLabel.Height = 25;
                EZLibLabel.Font = new Font("Lucida Console", 14);
                EZLibLabel.Location = new Point(118, 9);

                Label ErrorLabel = new Label();
                ErrorLabel.Text = "Your current hardware ID does not match " +
"the one you're trying to authenticate with.";
                ErrorLabel.Width = 306;
                ErrorLabel.Height = 22;
                ErrorLabel.Font = new Font("Lucida Console", 8);
                ErrorLabel.Location = new Point(7, 53);

                Label ErrorCodeLabel = new Label();
                ErrorCodeLabel.Text = "Error Code: 0x50S";
                ErrorCodeLabel.Width = 124;
                ErrorCodeLabel.Height = 11;
                ErrorCodeLabel.ForeColor = Color.Firebrick;
                ErrorCodeLabel.Font = new Font("Lucida Console", 8);
                ErrorCodeLabel.Location = new Point(7, 86);

                Button ButtonOK = new Button();
                ButtonOK.Text = "OK";
                ButtonOK.Font = new Font("Lucida Console", 8);
                ButtonOK.Size = new Size(75, 32);
                ButtonOK.Location = new Point(123, 118);

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
        }
        private static void loadingScreen()
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
                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.CenterScreen;

                Label ezlibLabel = new Label();
                ezlibLabel.Text = "EZLib";
                ezlibLabel.Width = 64;
                ezlibLabel.Height = 19;
                ezlibLabel.Font = new Font("Lucida Console", 14);
                ezlibLabel.Location = new Point(160, 9);

                Label loadingmsgLabel = new Label();
                loadingmsgLabel.Text = "Authenticating and loading program...";
                loadingmsgLabel.Width = 303;
                loadingmsgLabel.Height = 20;
                loadingmsgLabel.Font = new Font("Lucida Console", 10);
                loadingmsgLabel.Location = new Point(41, 84);

                Label copyrightlabel = new Label();
                copyrightlabel.Text = "Copyright 2017 EZLib";
                copyrightlabel.Width = 145;
                copyrightlabel.Height = 11;
                copyrightlabel.Font = new Font("Lucida Console", 8);
                copyrightlabel.Location = new Point(120, 158);

                form.Controls.Add(ezlibLabel);
                form.Controls.Add(loadingmsgLabel);
                form.Controls.Add(copyrightlabel);

                form.ShowDialog();

                System.Threading.Thread.Sleep(500);
                form.Hide();
            }
        }

        #endregion
    }
}