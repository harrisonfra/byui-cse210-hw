public class Receptions : Event
{
    private string[] _rsvpList = { "Dallas", "Carl Gibbons", "Sean Crosby", "Nate Phillips", "Matt Manley" };

    public Receptions(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public void RSVPCheck(string name)
    {
        bool found = false;

        foreach (string person in _rsvpList)
        {
            if (person.ToLower() == name.ToLower())
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"{name} is on the RSVP list.");
        }
        else
        {
            Console.WriteLine($"{name} is NOT on the RSVP list.");
        }
    }

    public string GetFullDetails()
    {
        Console.WriteLine();
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Required";
    }

    public string GetShortDescription()
    {
        Console.WriteLine();
        return $"Reception: {GetEventTitle()} on {GetDate()}";
    }
}