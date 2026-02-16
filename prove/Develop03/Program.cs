using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("What is the reference of the Scripture would you like to memorize?");
        string chicken = Console.ReadLine();
        Reference reference = new Reference(chicken);
        Console.WriteLine("What is the text of the Scripture would you like to memorize?");
        string text = Console.ReadLine();

        Scripture scripture1 = new Scripture(reference, text);


        while (true)
        {
            Console.Clear();
            scripture1.Display();

            if (scripture1.AllWordsHidden())
                break;

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture1.HideRandomWords();
        }

        Console.Clear();
        scripture1.Display();
        Console.WriteLine("All words hidden. Program ending.");
    }
}
