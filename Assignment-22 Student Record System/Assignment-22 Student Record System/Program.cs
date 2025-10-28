using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment_22_Student_Record_System
{
    /// <summary>
    /// Represents a student with Id, Name, and Grade.
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Grade { get; set; }

        // Convert student data to CSV format
        public string ToCsv() => $"{Id},{Name},{Grade}";
    }

    /// <summary>
    /// Manages student operations like adding, saving, loading, and displaying records.
    /// </summary>
    public class StudentRecordSystem
    {
        private List<Student> students = new();
        private const string FilePath = "students.csv";

        // Add new student record
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        // Display all students
        public void DisplayStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student records found!");
                return;
            }

            Console.WriteLine("\n Student Records:");
            Console.WriteLine("----------------------------");
            foreach (var s in students)
                Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Grade: {s.Grade}");
        }

        // Save all records to CSV file
        public void SaveToCsv()
        {
            using StreamWriter writer = new(FilePath);
            writer.WriteLine("Id,Name,Grade"); // Header
            foreach (var s in students)
                writer.WriteLine(s.ToCsv());

            Console.WriteLine($"\n Records saved successfully to '{FilePath}'.");
        }

        // Load student data from CSV file
        public void LoadFromCsv()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine(" No previous data found. Starting fresh!");
                return;
            }

            string[] lines = File.ReadAllLines(FilePath);

            // Skip header line
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data.Length == 3)
                {
                    students.Add(new Student
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Grade = double.Parse(data[2])
                    });
                }
            }

            Console.WriteLine(" Student records loaded successfully!");
        }
    }

    /// <summary>
    /// Main menu for interacting with the Student Record System.
    /// </summary>
    class Program
    {
        static void Main()
        {
            StudentRecordSystem system = new();
            system.LoadFromCsv(); // Load existing data

            int choice;
            do
            {
                Console.WriteLine("\n===== STUDENT RECORD SYSTEM =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Save Records to CSV");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                    choice = 0;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int id = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine() ?? "Unknown";

                        Console.Write("Enter Grade: ");
                        double grade = double.Parse(Console.ReadLine() ?? "0");

                        system.AddStudent(new Student { Id = id, Name = name, Grade = grade });
                        break;

                    case 2:
                        system.DisplayStudents();
                        break;

                    case 3:
                        system.SaveToCsv();
                        break;

                    case 4:
                        Console.WriteLine(" Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine(" Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
