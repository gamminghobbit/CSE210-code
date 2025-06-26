using System;

// Stretch Feature: Tracks total time spent across all activities and displays it at the end.
class Program
{
    static void Main(string[] args)
    {
        int totalTime = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                totalTime += activity.GetDuration(); // ✅ track time
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                totalTime += activity.GetDuration(); // ✅ track time
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                totalTime += activity.GetDuration(); // ✅ track time
            }
            else if (choice == "4")
            {
                Console.WriteLine($"\nYou completed a total of {totalTime} seconds of mindfulness activities today."); // ✅ display total
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}