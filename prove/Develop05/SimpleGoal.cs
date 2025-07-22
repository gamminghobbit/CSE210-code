class SimpleGoal : BaseGoal
{
    private bool Completed;

    public SimpleGoal(string name, string description, int points, bool completed = false)
        : base(name, description, points)
    {
        Type = "SimpleGoal";
        Completed = completed;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => Completed;

    public override string GetDisplayString()
    {
        return $"[{(Completed ? "X" : " ")}] {Name} ({Description})";
    }

    public override string ToString()
    {
        return $"{base.ToString()}|{Completed}";
    }
}
