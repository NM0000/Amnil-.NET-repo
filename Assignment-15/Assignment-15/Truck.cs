using System;

/// <summary>
/// Represents a truck, derived from the Vehicle class.
/// </summary>
public class Truck : Vehicle
{
    public double LoadCapacity { get; set; }

    public Truck(string brand, int year, double loadCapacity) : base(brand, year)
    {
        LoadCapacity = loadCapacity;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} Truck engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{Brand} Truck engine stopped.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck: {Brand}, Year: {Year}, Load Capacity: {LoadCapacity} tons");
    }
}
