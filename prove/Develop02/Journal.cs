using System.IO;
public class Journal
{
    public List<string> _entryList = new List<string> { };


    public Journal()
    {
    }

    public void LoadJournal()
    {
        Console.WriteLine("Enter file name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entryList.Clear(); //not sure if I should include this. 
        // Without it, if you write one entry, then load another
        //journal without saving your first entry, it combines them,
        //and you can save it into one journal. If I include it, it 
        //will delete your last entry. Including it is a cleaner solution, 
        //but may lead to unintended behavior. In a real use case, user may 
        //not end up writing without loading your journal first.

        foreach (string line in lines)
        {
             _entryList.Add(line);
        }
    }

    public void WriteEntry()
{
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    Entry myJournal = new Entry();
    string prompt = myJournal.GeneratePrompt();

    Console.WriteLine(prompt);
    string response = Console.ReadLine();

    _entryList.Add($"Date: {dateText} Prompt: {prompt} Response: {response},");
}

    public void SaveToJournal()
    {
        Console.WriteLine("Enter a filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entryList)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void DisplayEntries()
    {
        foreach (string entry in _entryList)
        {
            Console.WriteLine(entry);
        }
    }
}
