using System;
using System.Net;

namespace EZLib.Utility
{
    public class HttpClient : WebClient
    {
        public HttpClient(CookieContainer container)
        {
            CookieContainer = container;
        }

        public CookieContainer CookieContainer { get; set; } = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            var r = base.GetWebRequest(address);
            var request = r as HttpWebRequest;
            if (request != null)
            {
                request.CookieContainer = CookieContainer;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Proxy = null;
                request.Timeout = 10000;
                request.UserAgent = "EZLib (https://ezlib.rocks)";
            }
            return r;
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            var response = base.GetWebResponse(request, result);
            ReadCookies(response);
            return response;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            var response = base.GetWebResponse(request);
            ReadCookies(response);
            return response;
        }

        private void ReadCookies(WebResponse r)
        {
            var response = r as HttpWebResponse;
            if (response != null)
            {
                var cookies = response.Cookies;
                CookieContainer.Add(cookies);
            }
        }
    }
}