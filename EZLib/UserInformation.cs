using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZLib
{
    public class UserInformation
    {
        public static string currentUsername()
        {
            return Startup.username;
        }

        public static string currentProgramId()
        {
            return Startup.globalProgramId;
        }

        public static string currentLicense()
        {
            string webResponse;
            string apiUrl = "https://ezlib.rocks/api/endpoint.php?action=getLicense&username=" + currentUsername() + "&programId=" + currentProgramId() + "&format=plaintext";

            using (WebClient webClient = new WebClient())
            {
                webClient.Proxy = null;
                webClient.Headers.Set(HttpRequestHeader.UserAgent, "EZLib/1.0 +https://www.ezlib.rocks/");
                webResponse = webClient.DownloadString(apiUrl);

                return webResponse;
            }

        }
    }
}
