namespace Newtonsoft.Json.Linq
{
    public static class JTokenExtensions
    {
        public static string? GetSafeString(this JToken jtoken)
        {
            if (jtoken == null)
                return null;

            return jtoken.ToString();
        }
    }
}