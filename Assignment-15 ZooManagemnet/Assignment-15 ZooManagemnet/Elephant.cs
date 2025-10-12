using System;

/// <summary>
/// Represents an elephant, derived from Mammal.
/// </summary>
public class Elephant : Mammal
{
    public double TrunkLength { get; set; }

    public Elephant(string name, int age, string furColor, double trunkLength)
        : base(name, age, furColor)
    {
        TrunkLength = trunkLength;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets with its trunk!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Elephant: {Name}, Age: {Age}, Trunk Length: {TrunkLength} ft");
    }
}
