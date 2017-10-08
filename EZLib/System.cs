using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace EZLib
{
    internal class System
    {
        private readonly string apiCode = "dr2X2Je/jPSvdEcjr1Dzw2htDrJE+pV7zFlFyMPEePVp5snpe/PyPnFR21tjelcG";
        private readonly string apiEndpoint = "gg7ULYKMCmyug9v3JFgPFo4uIggtvfLnhnPn2z44kjd6heEj9VVYOkORh4SBFywS";
        private readonly string userAgent = "EZLib (https://ezlib.rocks/)";

        internal bool isInitialized;
        internal bool isSignedIn;
        internal bool isVerifiedDLL = true;

        #region API

        public void validateProgram(string program_id)
        {
            integrityCheck();

            if (isVerifiedDLL)
                using (var webClient = new WebClient())
                {
                    string webResponse;
                    var endpoint = decryptString(apiEndpoint);
                    var postData = "api_code=" + apiCode + "&api_action=verifyProgramID&program_id=" + program_id;

                    webClient.Proxy = null;
                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, userAgent);
                    webClient.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    webResponse = webClient.UploadString(endpoint, postData);

                    var apiJson = JsonConvert.DeserializeObject<dynamic>(webResponse);
                    var apiStatus = apiJson.status;

                    if (apiStatus == "success")
                        isInitialized = true;
                    else if (apiStatus == "error")
                        isInitialized = false;
                    else
                        Environment.Exit(0);
                }
            else
                Environment.Exit(0);
        }

        public void signIn(string username, string password)
        {
            if (isInitialized && isVerifiedDLL)
                using (var webClient = new WebClient())
                {
                    string webResponse;
                    var endpoint = decryptString(apiEndpoint);
                    var postData = "api_code=" + apiCode + "&api_action=signIn&username=" + username + "&password=" +
                                   password;

                    webClient.Proxy = null;
                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, userAgent);
                    webClient.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    webResponse = webClient.UploadString(endpoint, postData);

                    var apiJson = JsonConvert.DeserializeObject<dynamic>(webResponse);

                    var apiStatus = apiJson.status;
                    var apiReason = apiJson.reason;

                    var apiUsername = apiJson.username;
                    var apiIPAddress = apiJson.ip_address;
                    var apiHardwareId = apiJson.hardware_id;

                    if (apiStatus == "success")
                    {
                        isSignedIn = true;

                        var ezlib = new EZLib();

                        ezlib.myUsername = apiUsername;
                        ezlib.myIPAddress = apiIPAddress;
                        ezlib.myHardwareId = apiHardwareId;
                    }
                    else if (apiStatus == "error")
                    {
                        if (apiReason == "Password is incorrect")
                        {
                        }
                        else if (apiReason == "User does not exist")
                        {
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            else
                Environment.Exit(0);
        }

        private void integrityCheck()
        {
            string webResponse;
            var fileHash = BitConverter.ToString(ComputeHash(Environment.CurrentDirectory + "\\EZLib.dll"))
                .Replace("-", string.Empty);
            var endpoint = decryptString(apiEndpoint);
            var postData = "api_code=" + apiCode + "&api_action=verifyDLL&file_hash=" + fileHash;

            using (var webClient = new WebClient())
            {
                webClient.Proxy = null;
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, userAgent);
                webClient.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                webResponse = webClient.UploadString(endpoint, postData);

                var apiJson = JsonConvert.DeserializeObject<dynamic>(webResponse);
                var apiStatus = apiJson.status;

//                if (apiStatus == "success")
//                {
//                    isVerifiedDLL = true;
//                }
//                else if (apiStatus == "error")
//                {
//                    MessageBox.Show("This is not an authorized DLL of EZLib.", "Signature Mismatch",
//                        MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    Environment.Exit(0);
//                }
            }
        }

        #endregion

        #region Cryptography

        public string encryptString(string str)
        {
            var password = "EZLib_EStrings_jVSeD5";

            var mySHA256 = SHA256.Create();
            var key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
            var iv = new byte[16] {0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0};

            return Cryptography.EncryptString(str, key, iv);
        }

        public string decryptString(string str)
        {
            var password = "EZLib_EStrings_jVSeD5";

            var mySHA256 = SHA256.Create();
            var key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
            var iv = new byte[16] {0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0};

            return Cryptography.DecryptString(str, key, iv);
        }

        private byte[] ComputeHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(File.ReadAllBytes(filePath));
            }
        }

        #endregion
    }
}