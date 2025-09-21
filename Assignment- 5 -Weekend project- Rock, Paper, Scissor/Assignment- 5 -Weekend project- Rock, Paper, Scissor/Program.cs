using System;

namespace Assignment__5__Weekend_project__Rock__Paper__Scissor
{
    class Assignment_5
    {
        static void Main()
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {
                PlayRockPaperScissors();

                Console.Write("\nDo you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    keepPlaying = false;
                    Console.WriteLine("Thanks for playing! Goodbye!");
                }
            }
        }

        // Rock, Paper, Scissors Game

        static void PlayRockPaperScissors()
        {
            Console.WriteLine("\n--- Rock, Paper, Scissors ---");

            string userChoice = GetUserChoice();
            string computerChoice = GetComputerChoice();

            Console.WriteLine($"Computer chose: {computerChoice}");
            DetermineWinner(userChoice, computerChoice);
        }

        // Get user input with validation
        static string GetUserChoice()
        {
            Console.Write("Enter your choice (rock, paper, scissors): ");
            string choice = Console.ReadLine().ToLower();

            while (choice != "rock" && choice != "paper" && choice != "scissors")
            {
                Console.Write("Invalid choice! Please enter rock, paper, or scissors: ");
                choice = Console.ReadLine().ToLower();
            }

            return choice;
        }

        // Get computer choice randomly
        static string GetComputerChoice()
        {
            Random rand = new Random();
            string[] options = { "rock", "paper", "scissors" };
            return options[rand.Next(options.Length)];
        }

        // Decide winner
        static void DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                userChoice == "rock" && computerChoice == "scissors" ||
                userChoice == "paper" && computerChoice == "rock" ||
                userChoice == "scissors" && computerChoice == "paper"
            )
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}