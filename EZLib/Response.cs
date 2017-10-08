namespace EZLib
{
    public class Response
    {
        public bool InitializeResponse()
        {
            var System = new System();

            if (System.IsInitialized)
                return true;
            return false;
        }

        public bool LoginResponse()
        {
            var System = new System();

            if (System.IsSignedIn)
                return true;
            return false;
        }

        public bool RegisterResponse()
        {
            return false;
        }
    }
}