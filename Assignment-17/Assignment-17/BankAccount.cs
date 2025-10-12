using System;

/// <summary>
/// Custom exception for insufficient funds in a bank account.
/// </summary>
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

/// <summary>
/// Represents a simple bank account with basic operations and exception handling.
/// </summary>
public class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public double Balance { get; private set; }

    /// <summary>
    /// Constructor to initialize bank account.
    /// </summary>
    public BankAccount(string accountNumber, string ownerName, double initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
            throw new ArgumentException("Account number cannot be empty.");

        if (string.IsNullOrWhiteSpace(ownerName))
            throw new ArgumentException("Owner name cannot be empty.");

        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    /// <summary>
    /// Deposits the specified amount into the account.
    /// </summary>
    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
        Console.WriteLine($"Successfully deposited Rs.{amount}. Current balance: Rs.{Balance}");
    }

    /// <summary>
    /// Withdraws the specified amount from the account.
    /// </summary>
    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InsufficientFundsException("Insufficient funds for this withdrawal.");

        Balance -= amount;
        Console.WriteLine($"Successfully withdrew Rs.{amount}. Remaining balance: Rs.{Balance}");
    }

    /// <summary>
    /// Displays current balance.
    /// </summary>
    public void DisplayBalance()
    {
        Console.WriteLine($"Account: {AccountNumber} | Owner: {OwnerName} | Balance: Rs.{Balance}");
    }
}
