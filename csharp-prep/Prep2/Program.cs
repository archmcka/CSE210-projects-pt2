using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your current grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number >= 90)
        {
            Console.WriteLine(" you have an A in the class");
        }
        else if (number >= 80)
        {
            Console.WriteLine("you have a B in the class");
        }
        else if (number >= 70)
        {
            Console.WriteLine("you have a c in the class");
        }
        else if (number >= 60)
        {
            Console.WriteLine("you have a d int he class");
        }
        else if (number < 60)
        {
            Console.WriteLine("your have an F in this class ");
        }
        else 
        {
            Console.WriteLine("sorry that doesnt work");
        }
        Console.WriteLine("did you pass the class? ");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.WriteLine(" Great Job");
        }
        if (answer == "no")
        {
            Console.WriteLine("better luck next time");
        }

    }
}