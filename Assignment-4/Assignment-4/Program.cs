using System;

namespace Assignment_4
{
    class program
    {
        public static void Main()
        {
            bool LoopingProgram = true;

            while (LoopingProgram) 
            {
                //Creating a simple calculator 

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Compound Interest");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option (1-6): ");
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        ForAddition();
                        break;
                    case 2:
                        ForSubtraction();
                        break;
                    case 3:
                        ForMultiplcation();
                        break;
                    case 4:
                        ForDivision();
                        break;
                    case 5:
                        ForCompoundIntrest();
                        break;
                    case 6:
                        LoopingProgram = false;
                        Console.WriteLine("Exiting... Goodbyee");
                            break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }        

        static void ForAddition()
        {
            (int num1, int num2) = GetTwoNum();
            int Addtion = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {Addtion}");
        }

        static void ForSubtraction()
        {
            (int num1, int num2) = GetTwoNum();
            int Subtraction = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {Subtraction}");
        }

        static void ForDivision()
        {
            (int num1, int num2) = GetTwoNum();
            //validation divide my 0 not allowed
            if (num2 != 0)
            {
                int division = num1 / num2;
                Console.WriteLine($"Division {num1} / {num2} = {division}");
            }
            else
            {
                Console.WriteLine("Divsion by Zero is not allowed ");
            }
        }

        static void ForMultiplcation()
        {
            (int num1, int num2) = GetTwoNum();
            int Multiplication = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {Multiplication}");
        }

        static void ForCompoundIntrest()
        {
            // Compound Interest

            Console.Write("Enter Principal Amount(p): ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest(r in %): ");
            double r = double.Parse(Console.ReadLine()) / 100; //Convert percent into decimal

            Console.Write("Enter Time in years (t): ");
            int t = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of times interest is applied per year: ");
            int n = int.Parse(Console.ReadLine());

            double A = p * Math.Pow((1 + r / n), n * t);
            Console.WriteLine($"Compound Interest after {t} is {A:F2}");// :F2 limit upto 2 decimals
        }

        //Helper Method
        static (int, int) GetTwoNum()
        {
            Console.Write("Enter any number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter any number: ");
            int num2 = int.Parse(Console.ReadLine());

            return (num1, num2);
        }
    }
}