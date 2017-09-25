using System.Net;

namespace EZLib
{
    public class UserInformation
    {
        public static string userUsername()
        {
            return EZLib.apiAccess.currentUsername;
        }
        public static string userHardwareId()
        {
            return EZLib.Hardware_ID.Generate();
        }
        public static string userIPAddress()
        {
            return EZLib.apiAccess.ipAddressApi();
        }
        public static string userLicense()
        {
            // Adding in a bit
            return null;
        }
        public static string licenseExpiryDate()
        {
            // Adding in a bit
            return null;
        }
    }
}
