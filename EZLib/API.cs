using System;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZLib
{
    internal class apiAccess
    {
        public void registerApi(string username, string password)
        {
            try
            {
                string inputUsername = username;
                string inputPassword = password;
                string inputHardwareId = Hardware_ID.Generate();

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "username=" + inputPassword + "&password=" + inputPassword + "ip_address=" + "0.0.0.0" + "&hardware_id=" + inputHardwareId;
                byte[] data = encoding.GetBytes(postData);

                WebRequest webRequest = WebRequest.Create("https://ezlib.rocks/api/endpoint.php");
                webRequest.Method = "POST";
                webRequest.Proxy = null;
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = data.Length;
                webRequest.Headers.Add("user-agent", "Mozilla 5.0 (EZLib +https://ezlib.rocks/)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occcured! Error: " + ex.Message);
            }
        }

    }
}
