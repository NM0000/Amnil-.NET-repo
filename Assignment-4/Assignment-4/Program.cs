using System;

namespace Assignment_4
{
    class program
    {
        public static void Main()
        {
            //Creating a simple calculator 

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Compound Interest");
            Console.Write("Enter your option (1-5): ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch(option)
            {
                case 1:
                    break;

            }


            Console.Write("Enter any number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter any number: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int sub = a - b;
            int multiply = a * b;

            Console.WriteLine($"Addtion {a} + {b} = {sum}");
            Console.WriteLine($"Subtraction {a} - {b} = {sub}");
            Console.WriteLine($"Multiflication {a} * {b} = {multiply}");

            //validation divide my 0 not allowed
            if (b != 0)
            {
                int divide = a / b;
                Console.WriteLine($"Division {a} / {b} = {divide}");
            }
            else
            {
                Console.WriteLine("Divsion by Zero is not allowed ");
            }

            // Compound Interest
            // pinciple, rate, time, amount 

            Console.Write("Enter Principal Amount(p): ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest(r in %): ");
            double r = double.Parse(Console.ReadLine()) / 100; //Convert percent into decimal

            Console.Write("Enter Number of times interest is applied per year: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter Time in years (t): ");
            int t = int.Parse(Console.ReadLine());

            double A = p * Math.Pow((1 + r / n), n * t);

            Console.WriteLine($"Compound Interest after {t} is {A:F2}");// :F2 limit upto 2 decimals
        }
    }
}

using System;

class SimpleCalculator
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\n===== Simple Calculator =====");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Compound Interest");
            Console.Write("Enter your choice (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine(); // blank line for readability

            switch (choice)
            {
                case 1:
                    PerformAddition();
                    break;
                case 2:
                    PerformSubtraction();
                    break;
                case 3:
                    PerformMultiplication();
                    break;
                case 4:
                    PerformDivision();
                    break;
                case 5:
                    PerformCompoundInterest();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Ask if the user wants to continue
            Console.Write("\nDo you want to perform another calculation? (y/n): ");
            string response = Console.ReadLine().ToLower();
            if (response != "y")
            {
                keepRunning = false;
                Console.WriteLine("Exiting the calculator. Goodbye!");
            }
        }
    }

    //  Calculation Methods 
    static void PerformAddition()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
    }

    static void PerformSubtraction()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
    }

    static void PerformMultiplication()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
    }

    static void PerformDivision()
    {
        (double num1, double num2) = GetTwoNumbers();
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed!");
        }
        else
        {
            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        }
    }

    static void PerformCompoundInterest()
    {
        Console.Write("Enter Principal amount (P): ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (in %): ");
        double ratePercent = double.Parse(Console.ReadLine());
        double rate = ratePercent / 100; // convert % to decimal

        Console.Write("Enter number of times interest is compounded per year (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter time in years (t): ");
        double t = double.Parse(Console.ReadLine());

        // A = P(1 + r/n)^(nt)
        double amount = principal * Math.Pow(1 + rate / n, n * t);

        Console.WriteLine($"\nCompound Interest Amount (A): {amount:F2}");
    }

    //  Helper Method 
    static (double, double) GetTwoNumbers()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        return (num1, num2);
    }
}