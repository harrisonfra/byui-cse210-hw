using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04 Apr 2026", 30, 4));
        activities.Add(new StationaryCycle("04 Apr 2026", 45, 12));
        activities.Add(new Swimming("04 Apr 2026", 30, 32)); 

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}