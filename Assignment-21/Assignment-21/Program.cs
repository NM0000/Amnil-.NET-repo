using System;
using System.IO;

namespace Assignment_21
{
    /// <summary>
    /// Represents a text file processor that can count lines, words, characters,
    /// create backups, and search for specific text within files.
    /// </summary>
    public class TextFileProcessor
    {
        /// <summary>
        /// Counts the number of lines, words, and characters in the specified text file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        public void CountFileStatistics(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int lineCount = lines.Length;
                int wordCount = 0;
                int charCount = 0;

                foreach (string line in lines)
                {
                    wordCount += line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    charCount += line.Length;
                }

                Console.WriteLine("File Statistics:");
                Console.WriteLine($"Lines: {lineCount}");
                Console.WriteLine($"Words: {wordCount}");
                Console.WriteLine($"Characters: {charCount}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        /// <summary>
        /// Creates a backup copy of the specified file.
        /// </summary>
        /// <param name="filePath">Path of the file to back up.</param>
        public void CreateBackup(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string backupPath = filePath + ".backup";
                    File.Copy(filePath, backupPath, true);
                    Console.WriteLine($"Backup created successfully: {backupPath}");
                }
                else
                {
                    Console.WriteLine("Error: File does not exist!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating backup: {ex.Message}");
            }
        }

        /// <summary>
        /// Searches for a specific keyword or phrase in the text file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        /// <param name="searchText">Text to search for.</param>
        public void SearchText(string filePath, string searchText)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Error: File not found!");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                bool found = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found '{searchText}' on line {i + 1}: {lines[i]}");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"'{searchText}' not found in the file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while searching text: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Responsible for writing logs to a log file.
    /// </summary>
    public class LogFileWriter
    {
        private readonly string logFilePath;

        /// <summary>
        /// Initializes a new instance of the LogFileWriter class.
        /// </summary>
        /// <param name="path">Path of the log file.</param>
        public LogFileWriter(string path)
        {
            logFilePath = path;
        }

        /// <summary>
        /// Writes a log message with timestamp to the log file.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public void WriteLog(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] {message}");
                }
                Console.WriteLine("Log written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing log: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Demonstrates the use of TextFileProcessor and LogFileWriter classes.
    /// </summary>
    class Program
    {
        static void Main()
        {
            TextFileProcessor processor = new TextFileProcessor();
            LogFileWriter logger = new LogFileWriter("application.log");

            string filePath = "sample.txt";

            // Count file statistics
            processor.CountFileStatistics(filePath);
            logger.WriteLog("File statistics counted successfully.");

            // Create backup
            processor.CreateBackup(filePath);
            logger.WriteLog("Backup created.");

            // Search for text
            processor.SearchText(filePath, "hello");
            logger.WriteLog("Text search completed.");
        }
    }
}

