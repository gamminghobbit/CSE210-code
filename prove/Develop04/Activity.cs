using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        PauseWithSpinner(3);
    }

    public void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b");
            i = (i + 1) % spinner.Length;
        }
    }

    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}