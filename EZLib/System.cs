using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EZLib
{
    internal class System : Uri
    {
        private string PostData;
        private string WebResponse;
        private WebClient WebClient;
        private const string UserAgent = "EZLib (https://ezlib.rocks/)";
        private const string PostType = "application/www-x-form-urlencoded";

        internal bool IsSignedIn;
        internal bool IsInitialized;
        internal bool IsVerifiedDll;

        #region Cryptography

        private byte[] ComputeHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(File.ReadAllBytes(filePath));
            }
        }

        #endregion

        #region API

        public void InitializeProgram(string programId)
        {
            using (WebClient)
            {
                PostData = "ProgramID=" + programId;

                WebClient.Proxy = null;
                WebClient.Encoding = Encoding.UTF8;
                WebClient.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);
                WebClient.Headers.Add(HttpRequestHeader.ContentType, PostType);
                WebResponse = WebClient.UploadString(InitializeProgramApi, PostData);

                MessageBox.Show(WebResponse); // temp
            }
        }

        #endregion
    }
}