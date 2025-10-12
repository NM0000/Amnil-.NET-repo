using System;
using System.Buffers.Text;
using System.Linq;

namespace Assignment_10_mini_project
{
    class Program
    {
        // Maximum number of students and subjects (can be adjusted)
        static int maxStudents = 5;
        static int maxSubjects = 3;

        // Arrays to hold student names and grades
        static string[] studentNames = new string[maxStudents];
        static int[,] studentGrades = new int[maxStudents, maxSubjects];
        static string[] subjectNames = { "Math", "Science", "English" };

    // Counter to track number of students
    static int studentCount = 0;

        /// <summary>
        /// Entry point for Student Grade Management System.
        /// Displays a menu and allows the user to manage students and grades.
        /// </summary>
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Student Grade Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Enter Grades");
                Console.WriteLine("3. Display Report");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                 
                switch(choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        EnterGrades();
                        break;
                    case "3":
                        DisplayReport();
                        break;
                    case "4":
                        keepRunning = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Pause();
                        break;
                }
            }

            /// <summary>
            /// Adds a new student to the system.
            /// Validates input and ensures the student limit is not exceeded.
            /// </summary>
            static void AddStudent()
            {
                if (studentCount >= maxStudents)
                {
                    Console.WriteLine("Student limit reached. Cannot add more.");
                    Pause();
                    return;
                }

                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Invalid name. Try again.");
                    Pause();
                    return;
                }

                studentNames[studentCount] = name;
                studentCount++;
                Console.WriteLine("Student added successfully!");
                Pause();
            }

            /// <summary>
            /// Allows the user to enter grades for a specific student.
            /// Validates grade input to ensure values are between 0 and 100.
            /// </summary>
            static void EnterGrades()
            {
                if (studentCount == 0)
                {
                    Console.WriteLine("No students available. Add students first.");
                    Pause();
                    return;
                }

                Console.WriteLine("Select student:");
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentNames[i]}");
                }

                Console.Write("Enter student number: ");
                if (!int.TryParse(Console.ReadLine(), out int studentIndex) || studentIndex < 1 || studentIndex > studentCount)
                {
                    Console.WriteLine("Invalid choice.");
                    Pause();
                    return;
                }

                studentIndex--; // Adjust for array index

                for (int j = 0; j < maxSubjects; j++)
                {
                    Console.Write($"Enter grade for {subjectNames[j]} (0–100): ");
                    if (!int.TryParse(Console.ReadLine(), out int grade) || grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Invalid grade. Must be between 0 and 100.");
                        j--; // Repeat this subject
                    }
                    else
                    {
                        studentGrades[studentIndex, j] = grade;
                    }
                }

                Console.WriteLine("Grades entered successfully!");
                Pause();
            }

            /// <summary>
            /// Calculates the average grade for a given student.
            /// </summary>
            /// <param name="studentIndex">Index of the student in the array.</param>
            /// <returns>The average grade as a double.</returns>
            static double CalculateAverage(int studentIndex)
            {
                int total = 0;
                for (int j = 0; j < maxSubjects; j++)
                {
                    total += studentGrades[studentIndex, j];
                }
                return (double)total / maxSubjects;
            }

            /// <summary>
            /// Displays a report of all students, their grades, and average scores.
            /// </summary>
            static void DisplayReport()
            {
                if (studentCount == 0)
                {
                    Console.WriteLine("No students available.");
                    Pause();
                    return;
                }

                Console.WriteLine("\nStudent Report");
                for (int i = 0; i < studentCount; i++)
                {
                    double avg = CalculateAverage(i);
                    Console.WriteLine($"\nStudent: {studentNames[i]}");

                    for (int j = 0; j < maxSubjects; j++)
                    {
                        Console.WriteLine($"  Subject {j + 1}: {studentGrades[i, j]}");
                    }

                    Console.WriteLine($"  Average: {avg:F2}");
                }
                Pause();
            }

            /// <summary>
            /// Helper method to pause the console so the user can read the output.
            /// </summary>
            static void Pause()
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}