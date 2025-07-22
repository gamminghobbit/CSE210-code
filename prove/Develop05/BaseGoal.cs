abstract class BaseGoal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public string Type { get; protected set; }

    public BaseGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDisplayString();

    public override string ToString()
    {
        return $"{Type}|{Name}|{Description}|{Points}";
    }

    public static BaseGoal Deserialize(string record)
    {
        string[] parts = record.Split("|");
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "EternalGoal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
            case "ChecklistGoal":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
            default:
                return null;
        }
    }
}
