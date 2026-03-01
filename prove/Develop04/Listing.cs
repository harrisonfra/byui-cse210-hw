using System;
using System.Threading;

public class Listing : Menu
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand = new Random();

    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void StartListingActivity()
    {
        StartActivity();

        string prompt = GetRandomItem(_prompts);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(prompt);


        Console.WriteLine("Get ready to start...");
        Countdown(5);
        Console.WriteLine("Start listing! Type each item and press Enter:");

        DateTime endTime = GetEndTime();
        List<string> userItems = new List<string>();

        while (DateTime.Now < endTime)
        {
            string entry = Console.ReadLine();
            userItems.Add(entry);
        }

        Console.WriteLine($"You listed {userItems.Count} items!");


        SpinnyThing(2);
        Console.WriteLine($"Well done! You have completed the {_name} for {_duration} seconds.");
        SpinnyThing(5);
    }

    private string GetRandomItem(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return list[index];
    }
}