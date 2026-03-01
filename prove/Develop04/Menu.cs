using System;
using System.Threading;

public class Menu
{
    //Am I allowed to use protected member variables? I feel like this works best because the member variables can be accessed in inherited classes. Does this still fulfil the requirements of encapsulation? Thanks!
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayMenu()
    {
        string userInput = "";

        Console.WriteLine("Welcome to the mindfulness program!");

        while (userInput != "4")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Breathing breathing = new Breathing();
                breathing.StartBreathingActivity();
            }
            else if (userInput == "2")
            {
                Reflection reflection = new Reflection();
                reflection.StartReflectionActivity();
            }
            else if (userInput == "3")
            {
                Listing listing = new Listing();
                listing.StartListingActivity();
            }
            else if (userInput == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Input not recognized!");
            }
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_duration);
    }

    public void SpinnyThing(int seconds)
    //This is not the cleanest way to implement a spinner, but it works. Hahaha
    {

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }

        Console.Write(" ");
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

}