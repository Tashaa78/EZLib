using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EZLib
{
    internal class System : Uri
    {
        private const string UserAgent = "EZLib (https://ezlib.rocks/)";
        private const string PostType = "application/www-x-form-urlencoded";
        private string _postData;
        private string _webResponse;
        internal bool IsInitialized;

        internal bool IsSignedIn;
        internal bool IsVerifiedDll;
        private WebClient WebClient;

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
                _postData = "ProgramID=" + programId;

                WebClient.Proxy = null;
                WebClient.Encoding = Encoding.UTF8;
                WebClient.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);
                WebClient.Headers.Add(HttpRequestHeader.ContentType, PostType);
                _webResponse = WebClient.UploadString(InitializeProgramApi, _postData);

                MessageBox.Show(_webResponse); // temp
            }
        }

        #endregion
    }
}