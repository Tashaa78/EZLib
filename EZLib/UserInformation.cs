using System.Net;

namespace EZLib
{
    public class UserInformation
    {
        public static string currentUsername()
        {
            return EZLib.apiAccess.currentUsername;
        }

        public static string currentHardwareId()
        {
            return EZLib.Hardware_ID.Generate();
        }

        public static string currentIPAddress()
        {
            return EZLib.apiAccess.ipAddressApi();
        }
    }
}
