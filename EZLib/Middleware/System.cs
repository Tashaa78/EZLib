using System.Net;
using System.Text;

namespace EZLib
{
    internal class System
    {
        private const string UserAgent = "EZLib (https://ezlib.rocks/)";
        private const string PostType = "application/www-x-form-urlencoded";
        private WebClient WebClient;
        internal bool IsInitialized { get; set; }
        internal bool IsSignedIn { get; set; }
        internal bool IsVerifiedDll { get; set; }

        #region API

        public void InitializeProgram(string programId)
        {
            using (WebClient)
            {
                var postData = "ProgramID=" + programId;

                WebClient.Proxy = null;
                WebClient.Encoding = Encoding.UTF8;
                WebClient.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);
                WebClient.Headers.Add(HttpRequestHeader.ContentType, PostType);
                var webResponse = WebClient.UploadString(InitializeProgramApi, postData);

                // TODO: Decode JSON and handle it
            }
        }

        public void Login(string username, string password)
        {
            // TODO: Begin working on this API
        }

        #endregion

        #region API Endpoints

        public const string ApiEndpoint = "http://localhost/api/";

        public const string InitializeProgramApi = "http://localohost/api/InitializeProgram";
        public const string LoginApi = "http://localhost/api/SignIn";
        public const string RegisterApi = "http://localhost/api/SignUp";
        public const string LicenseCheck = "http://localhost/api/LicenseCheck";

        #endregion
    }
}