using System.Net;

namespace EZLib
{
    public class UserInformation
    {
        public static string userUsername()
        {
            return apiAccess.currentUsername;
        }
        public static string userHardwareId()
        {
            return Hardware_ID.Generate();
        }
        public static string userIPAddress()
        {
            return apiAccess.ipAddressApi();
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
