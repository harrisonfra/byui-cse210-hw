using System;
using System.Threading;

public class Reflection : Menu
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void StartReflectionActivity()
    {
        StartActivity();
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine(prompt);

        Console.WriteLine("When you have something in mind, press any key to continue. You will be asked questions to ponder about your experience.");
        Console.ReadLine();


        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            string question = GetRandomItem(_questions);
            Console.WriteLine(question);
            SpinnyThing(5);
        }

        Console.WriteLine("Great job reflecting!");
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
