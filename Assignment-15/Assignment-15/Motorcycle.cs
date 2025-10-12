using System;

/// <summary>
/// Represents a motorcycle, derived from the Vehicle class.
/// </summary>
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} Motorcycle engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{Brand} Motorcycle engine stopped.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle: {Brand}, Year: {Year}, Sidecar: {(HasSidecar ? "Yes" : "No")}");
    }
}