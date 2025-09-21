using System;
using System.Data.SqlTypes;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("-----List of Programs:-----");
                Console.WriteLine("1. List of Multiplication Tables From 1 to 100");
                Console.WriteLine("2. Guessing Number Game From 1 to 100");
                Console.WriteLine("3. Sum all even numbers between 1 and 100");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        listOfMultificationTable();
                        break;

                    case 2:
                        numberGuessingGame();
                        break;

                    case 3:
                        sumOfEvenNumber();
                        break;
                    case 4:
                        Console.WriteLine("Bye byee. Exiting Program!");
                        keepRunning =false;
                        break;
                }
            }
        }

        static void listOfMultificationTable()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        static void numberGuessingGame()
        {
            Console.WriteLine("===== Number Guessing Game =====");
            
            Random rand = new Random();
            int secretGuess = rand.Next(1, 101);
            int attempt = 0;
            int guess = 0;

            while (secretGuess != guess)
            {
                Console.Write("Enter your Guess number(1- 100): ");
                string guessNumber = Console.ReadLine();
                if (int.TryParse(guessNumber, out guess))
                {
                    attempt++;
                    if (guess > secretGuess)
                        Console.WriteLine("The guessed number is lower than your number.");
                    else if (guess < secretGuess)
                        Console.WriteLine("The guessed number is higher than your number");
                    else
                    {
                        Console.WriteLine("Congrats! Your have correctly guessed the Number");
                        Console.WriteLine($"It took your {attempt} attempts to guess the number {secretGuess} ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number. Please enter a number");
                }
            }
        }

        static void sumOfEvenNumber()
        {
            Console.WriteLine("=====Sum of Even Numbere (1 - 100)=====");
            int sumNumbers = 0;
            for (int i = 2; i <= 100; i+=2)
            {
                sumNumbers += i;
            }
            Console.WriteLine($"Sum of all the Even numbers from 1 to 100 is {sumNumbers}");
        }
    }
}