using System;
using System.Data;

class Entry
{
    public string date;
    public string prompt;
    public string entry;

    static string SelectPrompt()
    {
        List <string> prompts = [ 
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"];
        Random random = new();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public void WriteJournal(Journal currentJournal)
    {
        Entry entry = new Entry();
        entry.prompt=SelectPrompt();

        Console.WriteLine(entry.prompt);
        entry.entry=Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        currentJournal.journal.Add(entry);
    }
}