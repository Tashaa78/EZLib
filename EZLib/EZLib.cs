using System;

namespace EZLib
{
    public class EZLib
    {
        internal string MyUsername { get; }
        internal string MyIpAddress { get; }
        internal string MyLicenseKey { get; }
        internal string MyHardwareId { get; }

        public bool Initialize(string programId)
        {
            if (programId == String.Empty)
            {
                // TODO: Show error message
                return false;
            }
            else
            {
                var system = new System();
                system.InitializeProgram(programId);
                return system.IsInitialized;
            }
        }


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