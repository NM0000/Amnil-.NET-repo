using System;

class Program
{
    static void Main()
    {
        bool keepRunningProgram = true;

        while (keepRunningProgram)
        {
            menuSystem();
            Console.Write("Enter your Choice(1-2): ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine(); //blank space for readability

            switch (choice)
            {
                case 1:
                    convertIntoGrade();
                    break;

                case 2:
                    keepRunningProgram = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
            }

        }
        
    }

    static void menuSystem()
    {
        Console.WriteLine("\n<-----------Menu System--------->");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Exit");
    }

    static void convertIntoGrade()
    {
        Console.Write("\nEnter your Numerical Score for conversion (0-100): ");
        int score = int.Parse(Console.ReadLine());

        string grade;

        if (score > 90 && score <= 100)
            grade = "A+";
        else if (score > 80 && score <= 90)
            grade = "A";
        else if (score > 70 && score <= 80)
            grade = "B+";
        else if (score > 60 && score <= 70)
            grade = "B";
        else if (score > 50 && score <= 60)
            grade = "C+";
        else if (score > 40 && score <= 50)
            grade = "C";
        else if (score > 35 && score <= 40)
            grade = "D";
        else if (score >= 0 && score <= 35)
            grade = "F";
        else
        {
            Console.WriteLine("Invalid score! Must be between 0 and 100.");
            return;
        }

        Console.WriteLine($"\nYour Score {score} is equivalent to Grade {grade}");
    }
}