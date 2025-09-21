using System;

namespace Assignment_6_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Printing Patterns====");
            Console.WriteLine("1. Print Triangle Pattern");
            Console.WriteLine("2. Print Pyramid Pattern");
            Console.WriteLine("3. Print Diamond Pattern");
            Console.WriteLine("4. Exit");

            Console.WriteLine("\nEnter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    trianglePattern();
                    break;

                case 2:
                    pyramidPatterns();
                    break;
                case 3:
                    diamondPattern();
                    break;
                case 4:
                    break;
            }
        }

        static void trianglePattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        
        static void pyramidPatterns()
        {
            Console.WriteLine("\nPyramid:");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");
                for (int star = 1; star <= (2 * i - 1); star++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void diamondPattern()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
}