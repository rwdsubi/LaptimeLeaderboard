using System;
using System.Text.RegularExpressions;

namespace LaptimeLeaderboard.HelperFunctions
{
    public static class Codify
    {
        public static string Get(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }
    }
}
