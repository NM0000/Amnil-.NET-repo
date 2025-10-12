using System;

/// <summary>
/// Represents a basic automobile with core properties and behaviors.
/// </summary>
public class Car
{
    /// <summary>
    /// Gets or sets the manufacturer of the car.
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// Gets or sets the model of the car.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the manufacturing year of the car.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the color of the car.
    /// </summary>
    public string Color { get; set; }

    private bool _isRunning;
    private int _currentSpeed;

    /// <summary>
    /// Initializes a new instance of the <see cref="Car"/> class.
    /// </summary>
    /// <param name="make">The make of the car.</param>
    /// <param name="model">The model of the car.</param>
    /// <param name="year">The year of the car.</param>
    /// <param name="color">The color of the car.</param>
    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
        _isRunning = false;
        _currentSpeed = 0;
    }

    /// <summary>
    /// Starts the car's engine if it is not already running.
    /// </summary>
    /// <returns>A message indicating the result.</returns>
    public string Start()
    {
        if (_isRunning)
        {
            return "The engine is already running.";
        }
        _isRunning = true;
        return "The engine has started.";
    }

    /// <summary>
    /// Stops the car's engine if it is running.
    /// </summary>
    /// <returns>A message indicating the result.</returns>
    public string Stop()
    {
        if (!_isRunning)
        {
            return "The engine is already stopped.";
        }
        _isRunning = false;
        _currentSpeed = 0;
        return "The engine has stopped.";
    }

    /// <summary>
    /// Accelerates the car by 10 units if the engine is running.
    /// </summary>
    /// <returns>A message indicating the result, including new speed.</returns>
    public string Accelerate()
    {
        if (!_isRunning)
        {
            return "Cannot accelerate: Engine is not running.";
        }
        _currentSpeed += 10;
        return $"Accelerated. Current speed: {_currentSpeed} mph.";
    }

    /// <summary>
    /// Retrieves detailed information about the car, including current state.
    /// </summary>
    /// <returns>A formatted string with car details.</returns>
    public string GetInfo()
    {
        return $"Car: {Make} {Model} ({Year}), Color: {Color}. " +
               $"Engine Running: {_isRunning}, Speed: {_currentSpeed} mph.";
    }
}
