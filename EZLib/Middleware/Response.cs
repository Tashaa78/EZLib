namespace EZLib
{
    public class Response
    {
        private readonly System _system = new System();

        public bool InitializeResponse()
        {
            return _system.IsInitialized;
        }

        public bool LoginResponse()
        {
            return _system.IsSignedIn;
        }
    }
}