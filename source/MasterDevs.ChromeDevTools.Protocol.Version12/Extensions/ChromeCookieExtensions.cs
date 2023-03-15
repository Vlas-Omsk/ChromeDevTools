using System.Net;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class ChromeCookieExtensions
    {
        public static CookieCollection ToNetCookieCollection(this Chrome.Network.Cookie[] self)
        {
            var cookieCollection = new CookieCollection();

            foreach (var cookie in self)
                cookieCollection.Add(cookie.ToNetCookie());

            return cookieCollection;
        }

        public static Cookie ToNetCookie(this Chrome.Network.Cookie self)
        {
            return new Cookie()
            {
                Name = self.Name,
                Value = self.Value,
                Domain = self.Domain,
                Path = self.Path,
                // Expires = self.Expires,
                // HttpOnly = self.HttpOnly,
                Secure = self.Secure
            };
        }
    }
}
