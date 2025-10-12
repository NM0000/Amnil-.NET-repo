using System;

/// <summary>
/// Entry point for the Car demonstration console application.
/// </summary>
class Program
{
    /// <summary>
    /// The main entry point of the application.
    /// Creates multiple Car objects and tests their methods.
    /// </summary>
    static void Main()
    {
        // Create multiple car objects
        Car car1 = new Car("Toyota", "Camry", 2020, "Blue");
        Car car2 = new Car("Ford", "Mustang", 2018, "Red");
        Car car3 = new Car("Honda", "Civic", 2022, "Black");

        // Test functionality for car1
        Console.WriteLine("=== Testing Car 1 ===");
        Console.WriteLine(car1.GetInfo());
        Console.WriteLine(car1.Start());
        Console.WriteLine(car1.Accelerate());
        Console.WriteLine(car1.Accelerate());
        Console.WriteLine(car1.GetInfo());
        Console.WriteLine(car1.Stop());
        Console.WriteLine(car1.GetInfo());

        // Test functionality for car2
        Console.WriteLine("\n=== Testing Car 2 ===");
        Console.WriteLine(car2.Start());
        Console.WriteLine(car2.Accelerate());
        Console.WriteLine(car2.GetInfo());

        // Test functionality for car3 (minimal test)
        Console.WriteLine("\n=== Testing Car 3 ===");
        Console.WriteLine(car3.GetInfo());  // Engine off initially
        Console.WriteLine(car3.Accelerate());  // Should fail

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}