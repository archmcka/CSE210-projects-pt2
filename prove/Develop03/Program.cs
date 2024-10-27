using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture= new Scripture();
        bool validScripture = false;
        Console.Clear();
        while (!validScripture)
        {
            scripture = scripture.GetScripture();
            validScripture = true;

            while (!scripture.AllWordsHidden) 
            {
                Console.Clear();
                scripture.displayText();
                Console.Write("\nPress Enter to continue or type");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        scripture.displayText();
        Console.WriteLine();
    }

}
