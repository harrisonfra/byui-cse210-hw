public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;

        int earned = _points;

        if (_count == _target)
        {
            _checkedOff = true;
            earned += _bonus;
        }

        return earned;
    }

    public override string GetDetails()
    {
        string status;

        if (_checkedOff)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {_name} ({_description}) Completed {_count}/{_target}";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_target},{_bonus},{_count}";
    }
}