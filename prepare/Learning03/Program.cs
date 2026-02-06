using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetFractionDecimal());
        
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetFractionDecimal());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetFractionDecimal());

        Fraction frac4 = new Fraction();
        Random random= new Random();

        for (int i = 0; i < 20; i++)
        {
            frac4.SetTop(random.Next(1, 10));
            frac4.SetBottom(random.Next(1, 10));
            Console.WriteLine($"Fraction {i+1}: String: {frac4.GetFractionString()} Number: {frac4.GetFractionDecimal()}");
           
        }

    }
}