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
            return apiAccess.licenseInformation(apiAccess.currentProgramId, apiAccess.currentUsername, "licenseKey");
        }
        public static string licenseExpiryDate()
        {
            return apiAccess.licenseInformation(apiAccess.currentProgramId, apiAccess.currentUsername, "licenseExpiration");
        }
    }
}
