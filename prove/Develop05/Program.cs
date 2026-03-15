using System;
using System.Collections.Generic;
using System.IO;

class Program

{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine($"Score: {totalPoints}");

            Console.WriteLine("1. Create A Goal");
            Console.WriteLine("2. List Your Goals");
            Console.WriteLine("3. Record Completion of Goal");
            Console.WriteLine("4. Save Your Goals to File");
            Console.WriteLine("5. Load Your Goals From File");
            Console.WriteLine("6. Quit");

            Console.Write("Select option from menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Goal Types:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string userEntry = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string GoalDescription = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (userEntry == "1")
                {
                    goals.Add(new SimpleGoal(name, GoalDescription, points));
                }

                else if (userEntry == "2")
                {
                    goals.Add(new EternalGoal(name, GoalDescription, points));
                }

                else if (userEntry == "3")
                {
                    Console.Write("Times required: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, GoalDescription, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("Goals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("Which goal did you complete?");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
                }

                int index = int.Parse(Console.ReadLine()) - 1;

                int earned = goals[index].RecordEvent();
                totalPoints += earned;

                Console.WriteLine($"You earned {earned} points!");
            }

            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                List<string> lines = new List<string>();
                lines.Add(totalPoints.ToString());

                foreach (Goal g in goals)
                {
                    lines.Add(g.SaveString());
                }

                File.WriteAllLines(file, lines);
            }

            else if (choice == "5")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                string[] lines = File.ReadAllLines(file);

                goals.Clear();

                totalPoints = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",");

                    if (parts[0] == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }

                    else if (parts[0] == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }

                    else if (parts[0] == "ChecklistGoal")
                    {
                        goals.Add(new ChecklistGoal(
                            parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                    }
                }
            }

            else if (choice == "6")
            {
                Environment.Exit(0);
            }
        }
    }
}

