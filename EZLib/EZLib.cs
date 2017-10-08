using System;

namespace EZLib
{
    public class EZLib
    {
        internal string myHardwareId;
        internal string myIPAddress;
        internal string myLicenseKey;
        internal string myUsername;

        public bool Initialize(string program_id)
        {
            var System = new System();

            System.validateProgram(program_id);
            return System.isInitialized;
        }

        public bool Login(string username, string password)
        {
            var System = new System();

            if (System.isInitialized)
            {
                System.signIn(username, password);
                return System.isSignedIn;
            }
            Environment.Exit(0);
            return System.isSignedIn;
        }        
        
        #region User Information

        public string GetUsername()
        {
            return myUsername;
        }

        public string GetIPAddress()
        {
            return myIPAddress;
        }

        public string GetLicenseKey()
        {
            return myLicenseKey;
        }

        #endregion
    }
}