using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        Goals goals = new Goals("goals.txt");

        bool running = true;
        while (running)
        {
            Console.Clear();
            int choice = menu.DisplayMainMenu();
            switch (choice)
            {
                case 1:
                    goals.CreateGoal();
                    break;
                case 2:
                    goals.DisplayGoals();
                    break;
                case 3:
                    goals.RecordEvent();
                    break;
                case 4:
                    goals.DisplayScore();
                    break;
                case 5:
                    goals.Save();
                    break;
                case 6:
                    goals.Load();
                    break;
                case 7:
                    running = false;
                    break;
            }
        }
    }
}
