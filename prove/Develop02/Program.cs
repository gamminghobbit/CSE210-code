using System;
// Exceeds Requirements:
// I added a new option that allows user to write a custom prompt instead of only using random ones.
// this can improve the user's creativity and flexibility.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry (random prompt)");
            Console.WriteLine("2. Write a new entry (custom prompt)"); // <-- new option
            Console.WriteLine("3. Display the journal");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Save journal to file");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _prompt = prompt,
                    _response = response
                };

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                Console.Write("Enter your custom prompt: ");
                string customPrompt = Console.ReadLine();
                Console.WriteLine(customPrompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _prompt = customPrompt,
                    _response = response
                };

                journal.AddEntry(entry);
            }

            else if (choice == 3)
            {
                journal.DisplayJournal();
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 5)
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}
