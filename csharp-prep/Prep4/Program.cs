using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNum = -1;
        int sum = 0;
        float average = 0;
        int largestNum = 0;

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
                if (userNum > largestNum)
                {
                    largestNum = userNum;
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    sum = sum + number;
                }
            }

            average = ((float)sum) / numbers.Count;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}




// numbers.Add(int.Parse(Console.ReadLine()));