public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_checkedOff)
        {
            _checkedOff = true;
            return _points;
        }

        return 0;
    }

    public override string SaveString()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_checkedOff}";
    }
}