using System;

/// <summary>
/// Abstract base class representing a general vehicle.
/// </summary>
public abstract class Vehicle
{
    // Properties
    public string Brand { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    // Abstract methods to be implemented by derived classes
    public abstract void StartEngine();
    public abstract void StopEngine();
    public abstract void DisplayInfo();
}
