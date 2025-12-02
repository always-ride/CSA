using System.Text.RegularExpressions;

namespace MyLib
{
    public static class StringExtensions
    {
        public static bool IsValidEmailAddress(this string s)
        {
            var regex = new Regex(
            @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
    }
}
