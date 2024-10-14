using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;
        Entry entry = new(); 
        Journal currentJournal= new();
        do {
            Console.WriteLine("please selelct one of the choices. \n 1. new entry \n 2. display journal \n 3. save journal to file \n 4. load journal. \n 5. quit");
            Console.WriteLine("what would you like to do?");
            userChoice = int. Parse(Console.ReadLine());

            switch (userChoice) {
                case 1:// new entry
                    entry.WriteJournal(currentJournal);
                    break;
                case 2://display journal
                    currentJournal.ReadJournal();
                    break;
                case 3:// save journal
                    currentJournal.SaveJournal();
                    break;
                case 4:// load journal
                    Console.WriteLine("what file would you like to download?\n");
                    string fileName=Console.ReadLine();
                    currentJournal.LoadJournal(fileName);
                    Console.WriteLine($"{fileName}, was loaded successfully");
                    break;
                case 5://quit 
                    currentJournal.SaveJournal();
                    break;  

                
            }
        }while (userChoice !=5);
    }
}
//switch case for each of the menu options
//do while loop at the beginning of the switch that way it runs at least once.  