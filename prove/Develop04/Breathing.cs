using System;
using System.Threading;

public class Breathing : Menu
{
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void StartBreathingActivity()
    {
        StartActivity();
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Now breathe out...");
            Countdown(4);
        }
        Console.WriteLine($"Well done! You have completed the breathing activity for {_duration} seconds.");
        SpinnyThing(5);

    }
}