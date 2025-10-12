using System;

/// <summary>
/// Represents a lion, derived from Mammal.
/// </summary>
public class Lion : Mammal
{
    public Lion(string name, int age, string furColor) : base(name, age, furColor) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars loudly!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Lion: {Name}, Age: {Age}, Fur Color: {FurColor}");
    }
}
