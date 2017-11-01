using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using EZLib.Utility;
using Newtonsoft.Json;

namespace EZLib
{
    internal class EzLibSystem
    {
        private readonly HardwareId _hardwareId = new HardwareId();
        private readonly HttpClient _httpClient = new HttpClient(new CookieContainer());

        private readonly string _sessionId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
        private string CsrfToken { get; set; }
        private string ProgramId { get; set; }


        #region User Information

        internal string MyUsername { get; set; }
        internal string MyIpAddress { get; set; }
        internal string MyLicenseKey { get; set; }
        internal string MyLicenseKeyExpiry { get; set; }
        internal string MyHardwareId { get; set; }
        internal string MySessionId { get; set; }

        #endregion
        #region Response Booleans & Strings

        internal bool IsInitialized { get; set; }
        internal bool IsLoggedIn { get; set; }
        internal bool IsRegistered { get; set; }
        internal bool IsLicensed { get; set; }

        internal string InitializedReason { get; set; }
        internal string LoginReason { get; set; }
        internal string RegisterReason { get; set; }
        internal string LicenseReason { get; set; }

        #endregion


        #region API

        public void InitializeProgram(string programId)
        {
            ValidateCertificate();

            if (!IsInitialized)
                using (_httpClient)
                {
                    var postQuery = $"programId={programId}";
                    _httpClient.CookieContainer.Add(new Cookie("PHPSESSID", _sessionId, "/", "ezlib.rocks"));
                    var httpResonse = _httpClient.UploadString(InitializeProgramApi, postQuery);
                    var jsonResponse = JsonConvert.DeserializeObject<dynamic>(httpResonse);

                    if (jsonResponse.status == "success")
                    {
                        IsInitialized = true;
                        ProgramId = programId;

                        MySessionId = _sessionId;
                        CsrfToken = jsonResponse.csrf_token;
                    }
                    else if (jsonResponse.status == "error")
                    {
                        IsInitialized = false;
                        InitializedReason = jsonResponse.reason;
                    }
                    else
                    {
                        // TODO: Show EZLib critical error message
                        Environment.Exit(0);
                    }
                }
        }

        public void Login(string username, string password)
        {
            if (IsInitialized)
                if (!IsLoggedIn)
                    using (_httpClient)
                    {
                        var postQuery =
                            $"username={username}&password={password}&hardwareId={_hardwareId.Generate()}&csrfToken={CsrfToken}";
                        var httpResonse = _httpClient.UploadString(LoginApi, postQuery);
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(httpResonse);

                        if (jsonResponse.status == "success")
                        {
                            IsLoggedIn = true;
                            MyUsername = username;
                            MyIpAddress = jsonResponse.ip_address;
                            MyHardwareId = _hardwareId.Generate();
                        }
                        else if (jsonResponse.status == "error")
                        {
                            IsLoggedIn = false;
                            LoginReason = jsonResponse.reason;
                        }
                        else
                        {
                            // TODO: Show EZLib critical error message
                            Environment.Exit(0);
                        }
                    }
        }

        public void Register(string firstName, string lastName, string emailAddress, string username, string password)
        {
            if (IsInitialized)
                if (!IsLoggedIn)
                    using (_httpClient)
                    {
                        var postQuery =
                            $"firstName={firstName}&lastName={lastName}&emailAddress={emailAddress}&username={username}&password={password}&hardwareId={_hardwareId.Generate()}&csrfToken={CsrfToken}";
                        var httpResonse = _httpClient.UploadString(RegisterApi, postQuery);
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(httpResonse);

                        if (jsonResponse.status == "success")
                            IsRegistered = true;
                        else if (jsonResponse.status == "error")
                            RegisterReason = jsonResponse.reason;
                        else
                            Environment.Exit(0);
                    }
        }

        public void LicenseCheck()
        {
            if (IsInitialized)
                if (IsLoggedIn)
                    using (_httpClient)
                    {
                        var postQuery = $"programId={ProgramId}&username={MyUsername}&csrfToken={CsrfToken}";
                        var httpResonse = _httpClient.UploadString(LicenseCheckApi, postQuery);
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(httpResonse);

                        if (jsonResponse.status == "success")
                        {
                            IsLicensed = true;
                            MyLicenseKey = jsonResponse.license_key;
                            MyLicenseKeyExpiry = jsonResponse.expiration_date;

                        } else if (jsonResponse.status == "error")
                        {
                            IsLicensed = false;
                            LicenseReason = jsonResponse.reason;
                        }
                        else
                        {
                            // TODO: Show EZLib critical error message
                            Environment.Exit(0);
                        }
                    }
        }

        public void RegisterLicense(string licenseKey)
        {
            if (IsInitialized)
                if (IsLoggedIn)
                    using (_httpClient)
                    {
                        var postQuery = $"programId={ProgramId}&username={MyUsername}&licenseKey={licenseKey}&csrfToken={CsrfToken}";
                        var httpResonse = _httpClient.UploadString(RegisterLicenseApi, postQuery);
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(httpResonse);

                        if (jsonResponse.status == "success")
                        {
                            IsLicensed = true;
                            MyLicenseKey = jsonResponse.license_key;
                            MyLicenseKeyExpiry = jsonResponse.expiration_date;
                        }
                        else if (jsonResponse.status == "error")
                        {
                            IsLicensed = false;
                            LicenseReason = jsonResponse.reason;
                        }
                        else
                        {
                            // TODO: Show EZLib critical error message
                            Environment.Exit(0);
                        }
                    }
        }

        #endregion
        #region API Endpoints

        public const string ApiEndpoint = "https://ezlib.rocks/api";

        public const string InitializeProgramApi = "https://ezlib.rocks/api/InitializeProgram";
        public const string LoginApi = "https://ezlib.rocks/api/Login";
        public const string RegisterApi = "https://ezlib.rocks/api/Register";
        public const string LicenseCheckApi = "https://ezlib.rocks/api/LicenseCheck";
        public const string RegisterLicenseApi = "https://ezlib.rocks/api/RegisterLicense";

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
                    var message = "ERROR";
                    var caption = "Can't Validate Certificate Invalid Response Header(s)";
                    var buttons = MessageBoxButtons.OK;

                    // Displays the MessageBox.

                    MessageBox.Show(message, caption, buttons);

                    Environment.Exit(500);
                }
            }
            catch (WebException e) when (e.Status == WebExceptionStatus.Timeout)
            {
                var message = "ERROR";
                var caption = "Can't Validate Certificate Response Timeout";
                var buttons = MessageBoxButtons.OK;

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