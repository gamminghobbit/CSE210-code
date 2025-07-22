class EternalGoal : BaseGoal
{
    private int TimesCompleted;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points)
    {
        Type = "EternalGoal";
        TimesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        TimesCompleted++;
        return Points;
    }

    public override bool IsComplete() => false;

    public override string GetDisplayString()
    {
        return $"[∞] {Name} ({Description}) — Completed {TimesCompleted} times";
    }

    public override string ToString()
    {
        return $"{base.ToString()}|{TimesCompleted}";
    }
}
