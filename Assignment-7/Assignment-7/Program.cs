using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\n====== Assignment 7: Arrays and Collections ======");
                Console.WriteLine("1. Student Grades (Highest, Lowest, Average)");
                Console.WriteLine("2. Bubble Sort an Array");
                Console.WriteLine("3. Weekly Temperature Tracker");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StudentGrades();
                        break;

                    case "2":
                        BubbleSort();
                        break;

                    case "3":
                        WeeklyTemperatureTracker();
                        break;

                    case "4":
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StudentGrades()
        {
            List<Student> students = new List<Student>();
            bool runStudentGrade = true;

            while (runStudentGrade)
            {
                Console.WriteLine("\n=== Student Grades Program ===");
                Console.WriteLine("1. Add Student Grade");
                Console.WriteLine("2. View All Grades");
                Console.WriteLine("3. Show Statistics (Highest, Lowest, Average)");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter grade (0-100): ");
                        int grade;
                        while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                        {
                            Console.Write("Invalid grade. Enter a number between 0 and 100: ");
                        }

                        students.Add(new Student { Name = name, Grade = grade });
                        Console.WriteLine("Student grade added.");
                        break;

                    case "2":
                        Console.WriteLine("\n--- Student Grades ---");
                        if (students.Count == 0)
                            Console.WriteLine("No records yet.");
                        else
                            foreach (var student in students)
                                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
                        break;

                    case "3":
                        Console.WriteLine("\n--- Statistics ---");
                        if (students.Count == 0)
                            Console.WriteLine("No records yet.");
                        else
                        {
                            int highest = students.Max(s => s.Grade);
                            int lowest = students.Min(s => s.Grade);
                            double average = students.Average(s => s.Grade);

                            Console.WriteLine($"Highest: {highest}");
                            Console.WriteLine($"Lowest: {lowest}");
                            Console.WriteLine($"Average: {average:F2}");
                        }
                        break;

                    case "4":
                        runStudentGrade = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void BubbleSort()
        {
            {
                Console.WriteLine("\n====Bubble Sort====");
                int[] numbers = { 45, 12, 78, 34, 23, 89, 5 };

                Console.WriteLine("Original Array: " + string.Join(", ", numbers));

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = 0; j < numbers.Length - i - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
            }
        }

        static void WeeklyTemperatureTracker()
        {
            Console.WriteLine("\n===Weekly Temperature Tracker===");
            int[] temperatures = new int[7];

            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write($"Enter temperature for Day {i + 1}: ");
                temperatures[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nTemperatures for the Week:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }

            int maxTemp = temperatures[0], minTemp = temperatures[0], total = 0;

            foreach (int temp in temperatures)
            {
                if (temp > maxTemp) maxTemp = temp;
                if (temp < minTemp) minTemp = temp;
                total += temp;
            }

            double avgTemp = (double)total / temperatures.Length;

            Console.WriteLine($"\nHighest Temperature: {maxTemp}°C");
            Console.WriteLine($"Lowest Temperature: {minTemp}°C");
            Console.WriteLine($"Average Temperature: {avgTemp:F2}°C");
        }

    }
}