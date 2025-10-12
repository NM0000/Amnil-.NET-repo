using System;

/// <summary>
/// Demonstrates Zoo Management System with inheritance and polymorphism.
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Zoo Management System ===\n");

        // Array of Animal references showing polymorphism
        Animal[] zooAnimals = new Animal[]
        {
            new Lion("Leo", 5, "Golden"),
            new Elephant("Jumbo", 10, "Gray", 6.5),
            new Parrot("Coco", 2, 1.1, true),
            new Eagle("Arnold", 4, 2.5),
            new Snake("Cobra", 3, true),
            new Crocodile("Croc", 7, false)
        };

        // Demonstrate polymorphic behavior
        foreach (var animal in zooAnimals)
        {
            animal.DisplayInfo();
            animal.MakeSound();
            Console.WriteLine();
        }

        Console.WriteLine("=== End of Zoo Demonstration ===");
    }
}
