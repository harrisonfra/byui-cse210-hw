using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string magicNum = Console.ReadLine();
        //int magicNumberInt = int.Parse(magicNum);
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);
        int guessInt = 999;
        while (guessInt != magicNumberInt)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);

            if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}