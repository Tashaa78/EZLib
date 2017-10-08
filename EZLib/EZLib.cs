namespace EZLib
{
    public class EZLib
    {
        internal string MyUsername;
        internal string MyIpAddress;
        internal string MyLicenseKey;
        internal string MyHardwareId;
        
        #region User Information

        public string GetUsername()
        {
            return MyUsername;
        }

        public string GetIpAddress()
        {
            return MyIpAddress;
        }

        public string GetLicenseKey()
        {
            return MyLicenseKey;
        }

        public string GetHardwareId()
        {
            return MyHardwareId;
        }

        #endregion
    }
}