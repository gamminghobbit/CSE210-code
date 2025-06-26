using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            PauseWithCountdown(4);
            Console.Write("\nNow breathe out... ");
            PauseWithCountdown(4);

            elapsed += 8;
        }

        DisplayEndingMessage();
    }
}
