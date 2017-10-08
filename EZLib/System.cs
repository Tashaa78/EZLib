using System.Net;
using System.Text;

namespace EZLib
{
    internal class System
    {
        private const string UserAgent = "EZLib (https://ezlib.rocks/)";
        private const string PostType = "application/www-x-form-urlencoded";
        private string _postData;
        private string _webResponse;
        internal bool IsInitialized;

        internal bool IsSignedIn;
        internal bool IsVerifiedDll;
        private WebClient WebClient;

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

                // TODO: Decode JSON and handle it
            }
        }

        #endregion

        #region API Endpoints

        public const string ApiEndpoint = "http://localhost/api/";

        public const string InitializeProgramApi = "http://localohost/api/InitializeProgram";
        public const string LoginApi = "http://localhost/api/Login";

        #endregion
    }
}