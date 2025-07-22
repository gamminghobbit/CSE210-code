class Goals
{
    private List<BaseGoal> goalList = new List<BaseGoal>();
    private int totalScore = 0;
    private string dataFile;

    public Goals(string file)
    {
        dataFile = file;
    }

    public void CreateGoal()
    {
        Menu menu = new Menu();
        int type = menu.DisplayGoalTypeMenu();

        string name = menu.Prompt("Enter goal name: ");
        string desc = menu.Prompt("Enter description: ");
        int points = int.Parse(menu.Prompt("Enter point value: "));

        BaseGoal goal = null;

        if (type == 1)
            goal = new SimpleGoal(name, desc, points);
        else if (type == 2)
            goal = new EternalGoal(name, desc, points);
        else if (type == 3)
        {
            int target = int.Parse(menu.Prompt("Enter target count: "));
            int bonus = int.Parse(menu.Prompt("Enter bonus points: "));
            goal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        goalList.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalList[i].GetDisplayString()}");
        }
        Console.ReadLine();
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        DisplayGoals();
        int index = int.Parse(new Menu().Prompt("Which goal did you accomplish? ")) - 1;

        int earned = goalList[index].RecordEvent();
        totalScore += earned;

        Console.WriteLine($"You earned {earned} points!");
        Console.ReadLine();
    }

    public void Save()
    {
        using (StreamWriter writer = new StreamWriter(dataFile))
        {
            writer.WriteLine(totalScore);
            foreach (BaseGoal goal in goalList)
            {
                writer.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine("Goals saved!");
        Console.ReadLine();
    }

    public void Load()
    {
        if (File.Exists(dataFile))
        {
            string[] lines = File.ReadAllLines(dataFile);
            totalScore = int.Parse(lines[0]);
            goalList.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                goalList.Add(BaseGoal.Deserialize(lines[i]));
            }
        }
        Console.WriteLine("Goals loaded!");
        Console.ReadLine();
    }
}
