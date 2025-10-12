using System;
using System.Collections.Generic;

#region Vehicle Interfaces and Implementations

/// <summary>
/// Interface representing flying capability.
/// </summary>
interface IFlyable
{
    void Fly();
}

/// <summary>
/// Interface representing swimming capability.
/// </summary>
interface ISwimmable
{
    void Swim();
}

/// <summary>
/// Interface representing driving capability.
/// </summary>
interface IDriveable
{
    void Drive();
}

/// <summary>
/// Class representing an airplane that can fly.
/// </summary>
class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The airplane is flying high in the sky!");
    }
}

/// <summary>
/// Class representing a car that can drive.
/// </summary>
class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("The car is driving smoothly on the road.");
    }
}

/// <summary>
/// Class representing a boat that can swim.
/// </summary>
class Boat : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("The boat is sailing across the sea.");
    }
}

/// <summary>
/// Class representing an amphibious vehicle that can both drive and swim.
/// </summary>
class AmphibiousVehicle : IDriveable, ISwimmable
{
    public void Drive()
    {
        Console.WriteLine("The amphibious vehicle is driving on land.");
    }

    public void Swim()
    {
        Console.WriteLine("The amphibious vehicle is now swimming in the water.");
    }
}

#endregion

#region Media Player Interfaces and Implementations

/// <summary>
/// Interface representing basic media player functionality.
/// </summary>
interface IMediaPlayer
{
    void Play();
    void Pause();
    void Stop();
}

/// <summary>
/// Class representing an audio player.
/// </summary>
class AudioPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Audio is playing...");
    }

    public void Pause()
    {
        Console.WriteLine("Audio is paused.");
    }

    public void Stop()
    {
        Console.WriteLine("Audio playback stopped.");
    }
}

/// <summary>
/// Class representing a video player.
/// </summary>
class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Video is playing...");
    }

    public void Pause()
    {
        Console.WriteLine("Video is paused.");
    }

    public void Stop()
    {
        Console.WriteLine("Video playback stopped.");
    }
}

#endregion

#region Main Program

/// <summary>
/// Main program demonstrating interfaces and their implementations.
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Vehicle Interface Demonstration ===");
        List<object> vehicles = new List<object>()
        {
            new Airplane(),
            new Car(),
            new Boat(),
            new AmphibiousVehicle()
        };

        foreach (var vehicle in vehicles)
        {
            if (vehicle is IFlyable flyable)
                flyable.Fly();

            if (vehicle is IDriveable driveable)
                driveable.Drive();

            if (vehicle is ISwimmable swimmable)
                swimmable.Swim();

            Console.WriteLine("--------------------------------------");
        }

        Console.WriteLine("\n=== Media Player Interface Demonstration ===");

        IMediaPlayer audioPlayer = new AudioPlayer();
        IMediaPlayer videoPlayer = new VideoPlayer();

        Console.WriteLine("\n-- Audio Player --");
        audioPlayer.Play();
        audioPlayer.Pause();
        audioPlayer.Stop();

        Console.WriteLine("\n-- Video Player --");
        videoPlayer.Play();
        videoPlayer.Pause();
        videoPlayer.Stop();
    }
}

#endregion
