public class Lectures : Event
{
    private string _SpeakerName;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _SpeakerName = speaker;
        _capacity = capacity;
    }

    public void CapacityCheck()
    {
        if (_capacity > 0)
        {
            Console.WriteLine("Seats are available.");
        }
        else
        {
            Console.WriteLine("No seats available.");
        }
    }

    public string GetFullDetails()
    {
        Console.WriteLine();
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_SpeakerName}\nCapacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        Console.WriteLine();
        return $"Lecture: {GetEventTitle()} on {GetDate()}";
    }
}