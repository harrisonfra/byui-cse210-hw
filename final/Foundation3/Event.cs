public class Event
{
    private string _EventTitle;
    private string _description;
    private string _date;
    private Address _address;
    private string _time;

    public Event(string title, string description, string date, string time, Address address)

    {
        _EventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_EventTitle}\n{_description}\n{_date} at {_time}\n{_address.GetAddress()}";
    }

    public string GetEventTitle()
    {
        return _EventTitle;
    }

    public string GetDate()
    {
        return _date;
    }
}