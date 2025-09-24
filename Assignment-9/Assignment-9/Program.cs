using System;
using Assignment_9.Library;

namespace Assignment_9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string or line: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n--- String Utilities Output ---");
            Console.WriteLine($"Word Count      : {StringUtilities.CountWords(input)}");
            Console.WriteLine($"Reversed        : {StringUtilities.ReverseString(input)}");
            Console.WriteLine($"Is Palindrome   : {StringUtilities.IsPalindrome(input)}");
            Console.WriteLine($"Without Spaces  : {StringUtilities.RemoveSpaces(input)}");
        }
    }
}
