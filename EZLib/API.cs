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

    }
}
