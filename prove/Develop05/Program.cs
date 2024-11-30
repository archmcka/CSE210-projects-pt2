using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints=0;
        string UserSelection;

        bool running = true;
        while (running)
        {
            Console.WriteLine("welcome to the goal tracker program");
            Console.WriteLine("what would you like to do.");
            Console.WriteLine(" 1. create an eternal goal  2. create a simple goal. ");
            Console.WriteLine("3 create a check list goal 4. show points 5. record an event");

            UserSelection= Console.ReadLine();
            switch (UserSelection)
            {
                case "1":
                    Goal eternal = new Eternal().PromptGoalInfo();
                    goals.Add(eternal);
                    break;
                case "2":
                    Goal simple = new Simple().PromptGoalInfo();
                    goals.Add(simple);
                    break;
                case "3":
                    Goal checklist = new CheckList().PromptGoalInfo();  
                    goals.Add(checklist);
                    break;
                case "4":
                    Console.WriteLine($"you have {totalPoints} points");
                    break;
                case "5":
                    Console.WriteLine("which goal did you accomplish?");
                    int choice = int.Parse(Console.ReadLine())-1;
                    if (choice >= 0 && choice < goals.Count)
                    {
                        goals[choice].CompleteGoal();
                        totalPoints += goals[choice].GetpointValue();
                    }
                    break;
            }
        }
    }
}