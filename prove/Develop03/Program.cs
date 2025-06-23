using System;
// I add the stretch ability to allow the user to hide a desired letter. so when you say something like "a" all
// the A's will disappear.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide random words, type a single letter to hide it, or type 'quit' to end: ");
            string input = Console.ReadLine().ToLower();

            if (input == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords(3);
            }
            else if (input.Length == 1 && char.IsLetter(input[0]))
            {
                scripture.HideLetter(input[0]); // This method will be added in Scripture.cs
            }
        }
        Console.WriteLine("Program ended.");
    }
}