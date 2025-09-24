using System;

namespace Assignment_9.Library
{
    public static class StringUtilities
    {
        public static int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string[] words = input.Split(
                new char[] { ' ', '\t', '\n' },StringSplitOptions.RemoveEmptyEntries
            );

            return words.Length;
        }

        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string cleaned = input.Replace(" ", "").ToLower();
            string reversed = ReverseString(cleaned);

            return cleaned == reversed;
        }

        public static string RemoveSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Replace(" ", "");
        }
    }
}