using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Bank Account Exception Handling Demo ===\n");

        try
        {
            BankAccount account = new BankAccount("12345", "Nishil Maharjan", 5000);
            account.DisplayBalance();

            account.Deposit(2000);
            account.Withdraw(1000);
            account.Withdraw(7000); // This will trigger custom exception
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid Input: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nTransaction complete. Thank you!");
        }
    }
}
