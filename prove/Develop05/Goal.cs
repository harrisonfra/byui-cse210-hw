public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _checkedOff;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _checkedOff = false;
    }

    public virtual int RecordEvent()
    {
        _checkedOff = true;
        return _points;
    }

    public virtual string GetDetails()
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
        return $"{status} {_name} ({_description})";
    }

    public virtual string SaveString()
    {
        return $"Goal,{_name},{_description},{_points},{_checkedOff}";
    }
}