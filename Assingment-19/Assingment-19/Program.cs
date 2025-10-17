using System;
using System.Collections.Generic;
using System.Linq;

namespace Assingment_19
{
    /// <summary>
    /// Represents a student with basic academic details.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the full name of the student.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the student.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the grade of the student (e.g., A, B, C, D, F).
        /// </summary>
        public char Grade { get; set; }

        /// <summary>
        /// Gets or sets the major/field of study of the student.
        /// </summary>
        public string? Major { get; set; }
    }

    /// <summary>
    /// Demonstrates how to use LINQ queries to analyze student data.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Nishil Maharjan", Age = 21, Grade = 'A', Major = "Computer Science" },
                new Student { Name = "Rita KC", Age = 22, Grade = 'B', Major = "Computer Science" },
                new Student { Name = "Nisha Gurung", Age = 20, Grade = 'A', Major = "Business" },
                new Student { Name = "Binesh Rai", Age = 23, Grade = 'C', Major = "Engineering" },
                new Student { Name = "Suman Thapa", Age = 24, Grade = 'A', Major = "Engineering" },
                new Student { Name = "Aarati Shrestha", Age = 19, Grade = 'B', Major = "Business" },
                new Student { Name = "Kiran Lama", Age = 22, Grade = 'A', Major = "Data Science" }
            };

            // Filter students by grade (A students only)
            var aStudents = students.Where(s => s.Grade == 'A');
            Console.WriteLine("Students with Grade A:");
            foreach (var s in aStudents)
            {
                Console.WriteLine($"Name: {s.Name}, Major: {s.Major}");
            }

            Console.WriteLine("\n-----------------------------------");

            // Sort students by age
            var sortedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("Students sorted by Age:");
            foreach (var s in sortedByAge)
            {
                Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
            }

            Console.WriteLine("\n-----------------------------------");

            // Group students by major
            var groupedByMajor = students.GroupBy(s => s.Major);
            Console.WriteLine("Students grouped by Major:");
            foreach (var group in groupedByMajor)
            {
                Console.WriteLine($"\nMajor: {group.Key}");
                foreach (var s in group)
                {
                    Console.WriteLine($" - {s.Name} ({s.Grade})");
                }
            }

            Console.WriteLine("\n-----------------------------------");

            // Calculate average grade (convert grades to numeric values)
            // A=4, B=3, C=2, D=1, F=0
            var averageGradeValue = students.Average(s =>
            {
                switch (s.Grade)
                {
                    case 'A': return 4;
                    case 'B': return 3;
                    case 'C': return 2;
                    case 'D': return 1;
                    default: return 0;
                }
            });

            Console.WriteLine($" Average Grade (in numeric value): {averageGradeValue:F2}");

            Console.WriteLine("\n Program completed successfully.");
        }
    }
}
