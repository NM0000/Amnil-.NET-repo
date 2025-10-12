using System;

namespace Assignment12_BankAccount
{
    /// <summary>
    /// Represents a simple bank account with deposit and withdrawal features.
    /// </summary>
    public class BankAccount
    {
        // Private field for balance
        private decimal balance;

        /// <summary>
        /// Account number of the bank account.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Owner name of the bank account.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Current account balance (cannot be negative).
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Balance cannot be negative!");
                }
                else
                {
                    balance = value;
                }
            }
        }

        /// <summary>
        /// Constructor to initialize a new bank account.
        /// </summary>
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance >= 0 ? initialBalance : 0;
        }

        /// <summary>
        /// Deposits an amount into the account.
        /// </summary>
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        /// <summary>
        /// Withdraws an amount from the account (if sufficient balance exists).
        /// </summary>
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Error: Insufficient funds.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New balance: {Balance:C}");
            }
        }

        /// <summary>
        /// Returns the current account balance.
        /// </summary>
        public decimal GetBalance()
        {
            return Balance;
        }
    }

    /// <summary>
    /// Program entry point to test BankAccount class.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("ACC1001", "John Doe", 5000m);

            Console.WriteLine($"Account Owner: {acc1.OwnerName}");
            Console.WriteLine($"Account Number: {acc1.AccountNumber}");
            Console.WriteLine($"Initial Balance: {acc1.GetBalance():C}");
            Console.WriteLine();

            acc1.Deposit(2000m);
            acc1.Withdraw(1000m);
            acc1.Withdraw(7000m); // Test insufficient funds
        }
    }
}
