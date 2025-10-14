using System;
using System.Collections.Generic;

namespace Assignment_18_WordFrequencyCounterApp
{
    /// <summary>
    /// Counts word frequencies in a given text using a Dictionary.
    /// </summary>
    public class WordFrequencyCounter
    {
        /// <summary>
        /// Counts the number of occurrences of each word in the given text.
        /// </summary>
        /// <param name="text">The input text to analyze.</param>
        public void CountWords(string text)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            string[] words = text.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            Console.WriteLine("\nWord Frequency Results:");
            foreach (var pair in wordCount)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    /// <summary>
    /// Main program demonstrating the Word Frequency Counter using Dictionary.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Word Frequency Counter ===\n");

            WordFrequencyCounter counter = new WordFrequencyCounter();
            Console.Write("Enter a sentence:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            counter.CountWords(input);
        }
    }
}
