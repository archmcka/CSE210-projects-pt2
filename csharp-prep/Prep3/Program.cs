using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randongenerator = new Random();
        int magicNumber = randongenerator.Next(1,101);

        
        int guess = -2;
        //Console.WriteLine("guess the magic number. ");
        //string OgGuess = Console.ReadLine();
        //int guess= int.Parse(OgGuess);

        while (guess != magicNumber)
        {
            Console.WriteLine("guess the magic number. ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            } 
            else if (guess < magicNumber)
            {
               Console.WriteLine("higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("you guessed it!");
            }
        }
    }
}