using System;

namespace CompanyFormSubmission
{
    /// <summary>
    /// Custom exception for invalid name input.
    /// </summary>
    public class InvalidNameException : Exception
    {
        public InvalidNameException() { }
        public InvalidNameException(string message) : base(message) { }
    }

    /// <summary>
    /// Custom exception for invalid age input.
    /// </summary>
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }
        public InvalidAgeException(string message) : base(message) { }
    }

    /// <summary>
    /// Custom exception for invalid email input.
    /// </summary>
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException() { }
        public InvalidEmailException(string message) : base(message) { }
    }

    /// <summary>
    /// Class representing a company form submission.
    /// </summary>
    public class CompanyForm
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

        /// <summary>
        /// Validates form data and throws custom exceptions for invalid input.
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new InvalidNameException("Name cannot be empty.");
            }

            if (Age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above to submit the form.");
            }

            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                throw new InvalidEmailException("Email must contain '@' symbol.");
            }
        }

        /// <summary>
        /// Submits the form if validation passes.
        /// </summary>
        public void Submit()
        {
            Console.WriteLine("Form submitted successfully!");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    /// <summary>
    /// Main program to handle form submission and custom exception handling.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CompanyForm form = new CompanyForm();
            bool isSubmitted = false;

            Console.WriteLine("=== Company Form Submission ===");

            while (!isSubmitted)
            {
                try
                {
                    Console.Write("Enter your name: ");
                    form.Name = Console.ReadLine();

                    Console.Write("Enter your age: ");
                    form.Age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your email: ");
                    form.Email = Console.ReadLine();

                    // Validate form
                    form.Validate();

                    // If validation succeeds, submit the form
                    form.Submit();
                    isSubmitted = true;
                }
                catch (InvalidNameException ex)
                {
                    Console.WriteLine($" Error: {ex.Message}");
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine($" Error: {ex.Message}");
                }
                catch (InvalidEmailException ex)
                {
                    Console.WriteLine($" Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Error: Please enter a valid number for age.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Unexpected error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Form process attempt complete.\n");
                }
            }

            Console.WriteLine("Thank you for submitting your details!");
        }
    }
}
