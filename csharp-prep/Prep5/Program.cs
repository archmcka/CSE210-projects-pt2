using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
    static void DispleyWelcome()
    {
        Console.WriteLine("welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("please enter your name");
        string user_name=Console.ReadLine();

        return user_name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("please enter a number"); 
        int user_number =int.Parse(Console.ReadLine());

        return (user_number);
    }
    static int SquareNumber(user_number)
    {
        int squared_number = user_number**2
    }
}