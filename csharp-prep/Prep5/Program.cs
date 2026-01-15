using System;

class Program
{
    static void Main(string[] args)
    {
        int birthYear;

        DisplayWelcome();

        string name = PromptUserName();
        int userNum = PromptUserNumber();
        int square = SquareNumber(userNum);

        PromptUserBirthYear(out birthYear);

        DisplayResult(name, square, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int userNum)
    {

        return userNum * userNum;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year. ");
    }
}