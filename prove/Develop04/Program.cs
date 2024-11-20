using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userChoice;
        do
        {
            Console.WriteLine ("what activity would you like to do?");
            Console.WriteLine ("1. breathing ");
            Console.WriteLine ("2. reflecting");
            Console.WriteLine ("3. listing ");
            Console.WriteLine ("4. quit");
            userChoice= Console.ReadLine ();

           switch (userChoice) 
           {
                case "1":
                    Breathing breathing = new Breathing ();
                    breathing.Start();
                    break;
                case "2":
                    Reflection reflection = new Reflection ();  
                    reflection.Start ();
                    break;
                case "3":
                    Listing listing = new Listing ();
                    listing.Start ();
                    break;
                case "4":
                    Console.WriteLine("quitting......");
                    break;
                default:
                    Console.WriteLine("invalid option. please try agian");
                    break;
                
           }
        }while (userChoice != "4");
    }
}