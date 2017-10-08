namespace EZLib
{
    public class EZLib
    {
        internal string myHardwareId;
        internal string myIPAddress;
        internal string myLicenseKey;
        internal string myUsername;
        
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