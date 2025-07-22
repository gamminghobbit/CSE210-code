class Menu
{
    public int DisplayMainMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Quit");
        return int.Parse(Prompt("Select an option: "));
    }

    public int DisplayGoalTypeMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        return int.Parse(Prompt("Which type of goal would you like to create? "));
    }

    public string Prompt(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
