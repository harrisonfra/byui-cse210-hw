using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Josh Justice", "Homework");
        Console.WriteLine(assignment.GetSummary());

        WritingAssignment writingAssignment = new WritingAssignment("Aaron Fullmer", "History of Cellular Models", "Biology");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        MathAssignment mathAssignment = new MathAssignment("Aidan Sanchez", "Multiplication", "Section 10", "Problems 10-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}
