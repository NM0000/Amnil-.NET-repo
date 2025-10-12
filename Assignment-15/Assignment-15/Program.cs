using System;

/// <summary>
/// Demonstrates polymorphism with different types of vehicles.
/// </summary>
class Program
{
    static void Main()
    {
        // Create an array of Vehicle references
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Hyundai", 2022, 4),
            new Motorcycle("Royal Enfield", 2021, false),
            new Truck("Lamborghini ", 2023, 12.5)
        };

        Console.WriteLine("=== Vehicle Polymorphism Demo ===\n");

        // Demonstrate polymorphism
        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
            vehicle.DisplayInfo();
            vehicle.StopEngine();
            Console.WriteLine();
        }
    }
}
