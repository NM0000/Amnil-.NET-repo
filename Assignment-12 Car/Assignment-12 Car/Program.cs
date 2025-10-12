using System;

namespace Assignment12_Car
{
    /// <summary>
    /// Represents a car with basic details and functionalities.
    /// </summary>
    public class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Default constructor initializing with sample values.
        /// </summary>
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 2000;
            Color = "White";
        }

        /// <summary>
        /// Parameterized constructor to initialize car details.
        /// </summary>
        /// <param name="make">Car manufacturer name.</param>
        /// <param name="model">Car model name.</param>
        /// <param name="year">Year of manufacture.</param>
        /// <param name="color">Car color.</param>
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        /// <summary>
        /// Starts the car engine.
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting...");
        }

        /// <summary>
        /// Stops the car engine.
        /// </summary>
        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} has stopped.");
        }

        /// <summary>
        /// Accelerates the car.
        /// </summary>
        public void Accelerate()
        {
            Console.WriteLine($"{Make} {Model} is accelerating!");
        }

        /// <summary>
        /// Displays complete car information.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Car Info: {Year} {Color} {Make} {Model}");
        }
    }

    /// <summary>
    /// Program entry point to test Car class.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 2022, "Silver");
            car1.GetInfo();
            car1.Start();
            car1.Accelerate();
            car1.Stop();

            Console.WriteLine();

            Car car2 = new Car();
            car2.GetInfo();
        }
    }
}
