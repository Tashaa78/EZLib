using System;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EZLib
{
    internal class apiAccess
    {
        public static void registerApi(string username, string password)
        {
            try
            {
                string inputUsername = username;
                string inputPassword = password;
                string inputIPAddress = "0.0.0.0";
                string inputHardwareId = Hardware_ID.Generate();

                string webResponse;
                string postData = "action=register&username=" + inputUsername + "&password=" + inputPassword + "&ip_address=" + inputIPAddress + "&hardware_id=" + inputHardwareId;

                using (WebClient webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, "EZLib 1.0 +https://ezlib.rocks/");
                    webResponse = webClient.DownloadString("http://localhost/api/endpoint.php?" + postData);

                    if (webResponse.Contains("success"))
                    {
                        Form formControl = new UserControls.Alert_Messages.formMessage();

                        formControl.StartPosition = FormStartPosition.Manual;
                        formControl.ShowIcon = false;
                        formControl.ShowInTaskbar = false;
                        formControl.Opacity = 95;
                        formControl.Top = 60;
                        formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                        UserControls.Alert_Messages.alertMessage r_alertMessage  = new UserControls.Alert_Messages.alertMessage("You have successfully registered", UserControls.Alert_Messages.alertMessage.AlertType.success);
                        r_alertMessage.Dock = DockStyle.Fill;

                        formControl.Controls.Add(r_alertMessage);

                        formControl.ShowDialog();
                    } else if (webResponse.Contains("error"))
                    {
                        if (webResponse.Contains("Parameter missing"))
                        {
                            Environment.Exit(0);
                        } else if (webResponse.Contains("User already exists"))
                        {
                            Form formControl = new UserControls.Alert_Messages.formMessage();

                            formControl.StartPosition = FormStartPosition.Manual;
                            formControl.ShowIcon = false;
                            formControl.ShowInTaskbar = false;
                            formControl.Opacity = 95;
                            formControl.Top = 60;
                            formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                            UserControls.Alert_Messages.alertMessage r_alertMessage = new UserControls.Alert_Messages.alertMessage("This username already exists", UserControls.Alert_Messages.alertMessage.AlertType.warning);
                            r_alertMessage.Dock = DockStyle.Fill;

                            formControl.Controls.Add(r_alertMessage);

                            formControl.ShowDialog();
                        } else if (webResponse.Contains("IP address found"))
                        {
                            Form formControl = new UserControls.Alert_Messages.formMessage();

                            formControl.StartPosition = FormStartPosition.Manual;
                            formControl.ShowIcon = false;
                            formControl.ShowInTaskbar = false;
                            formControl.Opacity = 95;
                            formControl.Top = 60;
                            formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                            UserControls.Alert_Messages.alertMessage r_alertMessage = new UserControls.Alert_Messages.alertMessage("You have already registered once", UserControls.Alert_Messages.alertMessage.AlertType.error);
                            r_alertMessage.Dock = DockStyle.Fill;

                            formControl.Controls.Add(r_alertMessage);

                            formControl.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occcured! Error: " + ex.Message);
            }
        }
        public static void loginApi(string username, string password)
        {
            try
            {
                string inputUsername = username;
                string inputPassword = password;
                string inputHardwareId = Hardware_ID.Generate();

                string webResponse;
                string postData = "action=authenticate&username=" + inputUsername + "&password=" + inputPassword + "&hardware_id=" + inputHardwareId;

                using (WebClient webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, "EZLib 1.0 +https://ezlib.rocks/");
                    webResponse = webClient.DownloadString("http://localhost/api/endpoint.php?" + postData);

                    if (webResponse.Contains("success"))
                    {
                        Form formControl = new formControl();

                        formControl.StartPosition = FormStartPosition.Manual;
                        formControl.ShowIcon = false;
                        formControl.ShowInTaskbar = false;
                        formControl.StartPosition = FormStartPosition.CenterScreen;

                        UserControls.loaderControl l_alertMessage = new UserControls.loaderControl();
                        l_alertMessage.Dock = DockStyle.Fill;

                        formControl.Controls.Add(l_alertMessage);

                        formControl.ShowDialog();
                    }
                    else if (webResponse.Contains("error"))
                    {
                        if (webResponse.Contains("Parameter missing"))
                        {
                            Environment.Exit(0);
                        }
                        else if (webResponse.Contains("Password is incorrect"))
                        {
                            Form formControl = new UserControls.Alert_Messages.formMessage();

                            formControl.StartPosition = FormStartPosition.Manual;
                            formControl.ShowIcon = false;
                            formControl.ShowInTaskbar = false;
                            formControl.Opacity = 95;
                            formControl.Top = 60;
                            formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                            UserControls.Alert_Messages.alertMessage l_alertMessage = new UserControls.Alert_Messages.alertMessage("Your password is incorrect, try again", UserControls.Alert_Messages.alertMessage.AlertType.warning);
                            l_alertMessage.Dock = DockStyle.Fill;

                            formControl.Controls.Add(l_alertMessage);

                            formControl.ShowDialog();
                        }
                        else if (webResponse.Contains("Hardware ID does not match"))
                        {
                            Form formControl = new UserControls.Alert_Messages.formMessage();

                            formControl.StartPosition = FormStartPosition.Manual;
                            formControl.ShowIcon = false;
                            formControl.ShowInTaskbar = false;
                            formControl.Opacity = 95;
                            formControl.Top = 60;
                            formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                            UserControls.Alert_Messages.alertMessage l_alertMessage = new UserControls.Alert_Messages.alertMessage("Your Harware ID does not match", UserControls.Alert_Messages.alertMessage.AlertType.error);
                            l_alertMessage.Dock = DockStyle.Fill;

                            formControl.Controls.Add(l_alertMessage);

                            formControl.ShowDialog();
                        } else if (webResponse.Contains("User does not exist"))
                        {
                            Form formControl = new UserControls.Alert_Messages.formMessage();

                            formControl.StartPosition = FormStartPosition.Manual;
                            formControl.ShowIcon = false;
                            formControl.ShowInTaskbar = false;
                            formControl.Opacity = 95;
                            formControl.Top = 60;
                            formControl.Left = Screen.PrimaryScreen.Bounds.Width - formControl.Width - 60;

                            UserControls.Alert_Messages.alertMessage l_alertMessage = new UserControls.Alert_Messages.alertMessage("This account does not exist", UserControls.Alert_Messages.alertMessage.AlertType.warning);
                            l_alertMessage.Dock = DockStyle.Fill;

                            formControl.Controls.Add(l_alertMessage);

                            formControl.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occcured! Error: " + ex.Message);
            }
        }
        public static void authProgramApi(string programId)
        {
            try
            {
                string inputId = programId;

                string webResponse;
                string postData = "action=authenticateProgram&programId=" + inputId;

                using (WebClient webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, "EZLib 1.0 +https://ezlib.rocks/");
                    webResponse = webClient.DownloadString("http://localhost/api/endpoint.php?" + postData);

                    if (webResponse.Contains("success"))
                    {
                        Form formControl = new formControl();

                        formControl.ShowIcon = false;
                        formControl.ShowInTaskbar = false;
                        formControl.StartPosition = FormStartPosition.CenterScreen;

                        UserControls.loginControl loginControl = new UserControls.loginControl();
                        loginControl.Dock = DockStyle.Fill;

                        formControl.Controls.Add(loginControl);

                        formControl.ShowDialog();
                    }
                    else if (webResponse.Contains("error"))
                    {
                        Form formControl = new UserControls.Alert_Messages.formMessage();

                        formControl.StartPosition = FormStartPosition.Manual;
                        formControl.ShowIcon = false;
                        formControl.ShowInTaskbar = false;

                        UserControls.Alert_Messages.alertMessage alertMessage = new UserControls.Alert_Messages.alertMessage("This program ID is banned or does not exist", UserControls.Alert_Messages.alertMessage.AlertType.error);

                        formControl.Controls.Add(alertMessage);

                        formControl.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Error: " + ex.Message);
            }
        }
    }
}
