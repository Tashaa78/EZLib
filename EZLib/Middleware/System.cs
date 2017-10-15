using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using System.Windows.Forms;

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

        public const string ApiEndpoint = "http://localhost/api";

        public const string InitializeProgramApi = "http://localohost/api/InitializeProgram";
        public const string LoginApi = "http://localhost/api/SignIn";
        public const string RegisterApi = "http://localhost/api/SignUp";
        public const string LicenseCheck = "http://localhost/api/LicenseCheck";

        #endregion

        #region Validation

        private const string PublicKey =
                "3082010A0282010100ACE10BA14BA92ABA6D25A85B68ADCDC9CE695E4211ED32797F9DBEB59C9B3A0D2B4785A10AD4F3252D34F44EFE8105861D6BD9C79F5139E84657E58FF6FC2481BD4AD4D6A0A808AC61AF76F648D4508092F75D1E528232FB31EA28E205A9369BB75682BD6E6D94908500DF7AABDB914B627A89DF03DF2037D714C3E4330E40D7AE7E4F487D97D7ECC1717AA8F2988E6B84FE9CBB242E8B3657B970C09704904E707B32546BEA8B72AA26F204AB15A099E6CCAF1CAB2F029752534F1401CD7BCA49CDC51970ED01639C4FF3AADBBD1653F9C528DC2F0FB41AF435B0418B8F0DEF8FD4928F6991CEF2BBC71803EAFD9A24C441C9987E2D0F8ED28C9B3FE6E5463F0203010001"
            ;

        private void ValidateCertificate()
        {
            ServicePointManager.ServerCertificateValidationCallback = HpKp;
            try
            {

                var request = WebRequest.Create("https://ezlib.rocks/");
                request.Timeout = 10000;

                var response = request.GetResponse().Headers;


            if (response["SVR"] != "EZLib_Server")
            {
                
                string message = "ERROR";
                string caption = "Can't Validate Certificate Invalid Response Header(s)";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                
                // Displays the MessageBox.

                MessageBox.Show(message, caption, buttons);

                Environment.Exit(500);

            }
            }
            catch (WebException e) when (e.Status == WebExceptionStatus.Timeout)
            {

                string message = "ERROR";
                string caption = "Can't Validate Certificate Response Timeout";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.

                MessageBox.Show(message, caption, buttons);

                Environment.Exit(408);

            }
        }

        private static bool HpKp(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            if (certificate == null || chain == null)
                return false;

            if (sslPolicyErrors != SslPolicyErrors.None)
                return false;

            var pk = certificate.GetPublicKeyString();
            if (pk.Equals(PublicKey))
                return true;

            return false;
        }

        #endregion
    }
}