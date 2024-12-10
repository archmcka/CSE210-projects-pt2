using System;
using System.Diagnostics;

class Activity
{
   private string _name;
   private string _description;
   protected int _duration;
   public Activity(string name, string description)
   {
        _name = name;
        _description = description;
   }
   public int GetDuration()
   {
        Console.WriteLine("how long would you like the program to fun for? (seconds)");
        return int.Parse(Console.ReadLine());
   }
   public string GetStartingMessage()
   {
        Console.WriteLine("are you ready to start the program(yes or no) ");
        string starting_message=Console.ReadLine();
        return starting_message;
   }
   public void Prepare()
   {
    Console.Clear();
    Console.WriteLine("get ready...");
    Pause(3,false,true);
    Console.WriteLine("\n");
   }
   public void EndingMessage()
   {
        Console.WriteLine("you completed the activity.");
        Pause(3,false,true);
        Console.WriteLine("well done");
        Pause (3,false,true);
        Console.Clear();

   }
   public void Pause( int duration, bool countdown, bool annimation)
   {
        if (countdown)
        {
            for(int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);//pause function 
                Console.Write("\b \b");//annimation funciton
            }
        }
        else if (annimation)
        {
            List<string> annimationSymbols= ["|","/","-","\\"];

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string symbol = annimationSymbols[i];
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the previous symbol
                i = (i + 1) % annimationSymbols.Count;
            }
        }
        else 
        {
            Thread.Sleep(duration*1000);
        }
   }
}


