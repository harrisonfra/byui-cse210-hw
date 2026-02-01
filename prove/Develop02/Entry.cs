using System.IO;
public class Entry
{
        List<string> stringsList = new List<string>
        {
            "What has the spirit been trying to teach you today?",
            "What gave your life meaning today?",
            "What are you working on right now, and why is it important?",
            "What small decision you made today helped you to become 1 percent better",
            "What are you avoiding thinking about right now. Why?",
            "If your life were a book, and today was a chapter, what is its title?",
            "What stood out to you today?"
        };

    public Entry()
    {
    }

    public void Exit()
    {
        System.Environment.Exit(0);
    }

    public string GeneratePrompt()
    {
        Random rand = new Random();
        string randomPrompt = stringsList[rand.Next(stringsList.Count)];
        return (randomPrompt);
    }
}