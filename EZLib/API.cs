using System;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string inputIPAddress = "";
                string inputHardwareId = Hardware_ID.Generate();

                string postData = "action=register&username=" + inputPassword + "&password=" + inputPassword + "&ip_address=" + inputIPAddress + "&hardware_id=" + inputHardwareId;

                using (WebClient webClient = new WebClient())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occcured! Error: " + ex.Message);
            }
        }

    }
}
