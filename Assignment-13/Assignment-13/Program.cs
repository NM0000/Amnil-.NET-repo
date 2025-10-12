using System;

namespace EmployeeManagement
{
    /// <summary>
    /// Represents an employee with name, age, and salary details.
    /// Includes validation and a method to calculate yearly bonus.
    /// </summary>
    class Employee
    {
        // Private fields
        private string _name;
        private int _age;
        private double _salary;

        /// <summary>
        /// Gets or sets the employee's name. Cannot be empty or null.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the employee's age. Must be between 18 and 65.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 65)
                    throw new ArgumentException("Age must be between 18 and 65.");
                _age = value;
            }
        }

        /// <summary>
        /// Gets or sets the employee's salary. Must be a positive number.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Salary must be positive.");
                _salary = value;
            }
        }

        /// <summary>
        /// Constructor to initialize an employee with name, age, and salary.
        /// </summary>
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        /// <summary>
        /// Calculates the yearly bonus (10% of the salary).
        /// </summary>
        /// <returns>Returns the calculated bonus as a double.</returns>
        public double CalculateYearlyBonus()
        {
            return Salary * 0.10;
        }

        /// <summary>
        /// Displays the employee details and calculated bonus.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Yearly Bonus: {CalculateYearlyBonus():C}");
        }
    }

    /// <summary>
    /// Main class to test the Employee class.
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                // Create an employee object
                Employee emp = new Employee("Nishil Maharjan", 30, 80000);

                // Display employee info
                emp.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
