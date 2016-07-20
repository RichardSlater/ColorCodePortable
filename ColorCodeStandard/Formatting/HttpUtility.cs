using System;

namespace ColorCode.Formatting
{
    public static class HttpUtility
    {
        public static string HtmlEncode(string value)
        {
#if NETCORE
            return System.Net.WebUtility.HtmlEncode(value);
#elif NET35
            return System.Web.HttpUtility.HtmlEncode(value);
#elif NET40
            return System.Net.WebUtility.HtmlEncode(value);
#elif PORTABLE
            return System.Windows.Browser.HttpUtility.HtmlEncode(value);
#endif
        }
    }
}