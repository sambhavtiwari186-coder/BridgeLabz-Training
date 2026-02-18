using System;
using System.Text.RegularExpressions;

namespace TechVilleSmartCity.Utilities
{
    public class StringUtilities
    {
        // Format Name (First letter capital)
        public static string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return name;

            name = name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        // Email Validation
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Extract PIN from Address (Assume 6 digit PIN)
        public static string ExtractPin(string address)
        {
            Match match = Regex.Match(address, @"\d{6}");
            return match.Success ? match.Value : "No PIN Found";
        }

        // Search by name (Contains logic)
        public static bool NameContains(string source, string keyword)
        {
            return source.ToLower().Contains(keyword.ToLower());
        }
    }
}
