namespace EZLib
{
    public class Response
    {
        public bool InitializeResponse()
        {
            var System = new System();

            if (System.isInitialized)
                return true;
            return false;
        }

        public bool LoginResponse()
        {
            var System = new System();

            if (System.isSignedIn)
                return true;
            return false;
        }

        public bool RegisterResponse()
        {
            return false;
        }
    }
}