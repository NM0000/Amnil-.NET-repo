using System;

namespace ConsoleApp1
{
    ///<summary>
    ///This class is gor logical operation of the guessing game
    ///</summary>
    public class Game
    {
        int secretNum;
        int attempts;

        ///<summary> 
        ///Starting a game Generating a RANDOM number. 
        ///</summary>
        public void StartGame()
        {
            Random random = new();
            secretNum = random.Next(1, 11);//Random number betwn 1 to 10.
            attempts = 0;

            Console.WriteLine("Welcome to Guessing game");
            Console.WriteLine("Choose your guessing number 1 to 10");
        }
            ///<summary>
            ///Checks the players guess aganist Computers choosen number.
            ///</summary>
            ///<param name="guessedNum">
            ///This is the number guessed by the players.
            ///</param>
            ///<returns>
            ///Returns true if the number is correct, otherwise false.
            ///</returns>
            public bool CheckedGuessedNum(int guessedNum)
        {
            attempts++;
            if (guessedNum == secretNum)
            {
                Console.WriteLine($"Correct Guess! You took only {attempts}attempts");
                return true;
            }
            else if (guessedNum < secretNum)
            {
                Console.WriteLine("Guessed Number is too low. Try once more");
            }
            else
            {
                Console.WriteLine("Gussed Number is too high. Try once more");
            }
            return false;
        }
        
        class Program
        {
            ///<summary>
            ///Entry point for program
            ///</summary>
            public static void Main()
            {
                Game game = new();
                game.StartGame();   
                bool guessedCorrectly = false;
                while (!guessedCorrectly)
                {
                    Console.Write("Enter your guess: ");

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int guessedNum))
                    {
                        guessedCorrectly = game.CheckedGuessedNum(guessedNum);
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number.");
                    }
                }
            }
        }
    }
}