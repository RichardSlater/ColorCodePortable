using System;

namespace ColorCode.Formatting
{
    public class HttpUtility
    {
        public static string HtmlEncode(string value)
        {
            return System.Net.WebUtility.HtmlEncode(value);
        }
    }
}