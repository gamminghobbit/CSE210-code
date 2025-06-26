using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _responses = new List<string>();

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
        }

        Console.WriteLine($"\nYou listed {_responses.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}