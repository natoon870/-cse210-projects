class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public Checklist(string name, string description, int points,
                     int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    private bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override int RecordGoal()
    {
        _currentCount++;

        int total = GetPoints();

        if (_currentCount == _targetCount)
        {
            total += _bonus;
            Console.WriteLine($"You completed '{GetName()}' {_currentCount}/{_targetCount} and earned {GetPoints()} + BONUS {_bonus}!");
        }
        else
        {
            Console.WriteLine($"You recorded '{GetName()}' {_currentCount}/{_targetCount} and earned {GetPoints()} points.");
        }

        return total;
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "X" : " ";
        return $"[{check}] {GetName()} ({GetDescription()}) -- Currently Completed {_currentCount}/{_targetCount}";
    }

    public override string GetRepresentation()
    {
        return $"Checklist:{GetName()},{GetDescription()},{GetPoints()},{_currentCount},{_targetCount},{_bonus}";
    }
}