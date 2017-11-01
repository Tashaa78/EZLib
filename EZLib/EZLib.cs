using System;

namespace EZLib
{
    public class EzLib
    {
        internal static readonly EzLibSystem System = new EzLibSystem();

        #region Initialize Methods

        public void Initialize(string programId)
        {
            try
            {
                System.InitializeProgram(programId);
            }
            catch (Exception ex)
            {
                using (var exceptionForm = new Utility.exceptionForm(ex.GetType().Name, ex.Message, ex.StackTrace))
                {
                    exceptionForm.ShowDialog();
                }
            }
        }

        public bool InitializeResponse()
        {
            return System.IsInitialized;
        }

        public string InitializeResponseReason()
        {
            return System.InitializedReason;
        }

        #endregion
        #region Login Methods

        public void Login(string username, string password)
        {
            try
            {
                System.Login(username, password);
            }
            catch (Exception ex)
            {
                using (var exceptionForm = new Utility.exceptionForm(ex.GetType().Name, ex.Message, ex.StackTrace))
                {
                    exceptionForm.ShowDialog();
                }
            }
        }

        public bool LoginResponse()
        {
            return System.IsLoggedIn;
        }

        public string LoginResponseReason()
        {
            return System.LoginReason;
        }

        #endregion
        #region Register Methods

        public void Register(string firstName, string lastName, string emailAddress, string username, string password)
        {
            try
            {
                System.Register(firstName, lastName, emailAddress, username, password);
            }
            catch (Exception ex)
            {
                using (var exceptionForm = new Utility.exceptionForm(ex.GetType().Name, ex.Message, ex.StackTrace))
                {
                    exceptionForm.ShowDialog();
                }
            }
        }

        public bool RegisterResponse()
        {
            return System.IsRegistered;
        }

        public string RegisterResponseReason()
        {
            return System.RegisterReason;
        }

        #endregion
        #region License Methods

        public void CheckLicense()
        {
            try
            {
                System.LicenseCheck();
            }
            catch (Exception ex)
            {
                using (var exceptionForm = new Utility.exceptionForm(ex.GetType().Name, ex.Message, ex.StackTrace))
                {
                    exceptionForm.ShowDialog();
                }
            }
        }

        public void RegisterLicense(string licenseKey)
        {
            try
            {
                System.RegisterLicense(licenseKey);
            }
            catch (Exception ex)
            {
                using (var exceptionForm = new Utility.exceptionForm(ex.GetType().Name, ex.Message, ex.StackTrace))
                {
                    exceptionForm.ShowDialog();
                }
            }
        }

        public bool IsLicensedResponse()
        {
            return System.IsLicensed;
        }

        public string LicenseResponseReason()
        {
            return System.LicenseReason;
        }

        #endregion

        #region User Information

        public string GetUsername()
        {
            return System.MyUsername;
        }

        public string GetIpAddress()
        {
            return System.MyIpAddress;
        }

        public string GetLicenseKey()
        {
            return System.MyLicenseKey;
        }

        public string GetExpirationDate()
        {
            return System.MyLicenseKeyExpiry;
        }

        public string GetHardwareId()
        {
            return System.MyHardwareId;
        }

        public string GetSessionId()
        {
            return System.MySessionId;
        }

        #endregion
    }
}