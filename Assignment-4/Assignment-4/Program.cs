using System;

namespace Assignment_4
{
    class program
    {
        public static void Main(string[] args)
        {
            //Creating a simple calculator 

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

            double  A = p* Math.Pow((1 + r / n), n * t);

            Console.WriteLine($"Compound Interest after {t} is {A:F2}");// :F2 limit upto 2 decimals
        }
    }
}