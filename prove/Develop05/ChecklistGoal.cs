class ChecklistGoal : BaseGoal
{
    private int TargetCount;
    private int CompletedCount;
    private int BonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int completedCount = 0)
        : base(name, description, points)
    {
        Type = "ChecklistGoal";
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CompletedCount = completedCount;
    }

    public override int RecordEvent()
    {
        if (CompletedCount < TargetCount)
        {
            CompletedCount++;
            if (CompletedCount == TargetCount)
                return Points + BonusPoints;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => CompletedCount >= TargetCount;

    public override string GetDisplayString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) — Completed {CompletedCount}/{TargetCount}";
    }

    public override string ToString()
    {
        return $"{base.ToString()}|{TargetCount}|{BonusPoints}|{CompletedCount}";
    }
}
