using System;

/// <summary>
/// Represents a car, derived from the Vehicle class.
/// </summary>
public class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(string brand, int year, int doors) : base(brand, year)
    {
        Doors = doors;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} Car engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{Brand} Car engine stopped.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand}, Year: {Year}, Doors: {Doors}");
    }
}
