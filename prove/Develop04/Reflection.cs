using System.Diagnostics.CodeAnalysis;

class Reflection : Activity
{
    private List<string>_events=
    [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string>_prompts =
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    public Reflection() : base("reflection", "this activity will help you reflect on the times in your life when you have shown strength and resiliance .")
    {
    }
    public void Start()
    {
        GetStartingMessage();
        _duration =GetDuration();
        Prepare();
        DisplayEvent();

        Console.WriteLine("when you have somethin in mind press enter to continue");
        Console.ReadLine();

        Console.WriteLine("now ponder on each of the following questions as they relate to the experience");
        Console.Write("you may begin in ");
        Pause(3,true,false);
        Console.Clear();

        DisplayPrompt();
        Console.WriteLine();
        EndingMessage();
    }
    public void DisplayEvent()
    {
        Random random = new();
        string prompt = _events[random.Next(_events.Count())];
        _events.Remove(prompt);
        Console.WriteLine("consider the following prompt: ");
        Console.WriteLine({prompt});
    }
    public void DisplayPrompt()
    {
        Random random = new();
        int promptTime =GetPromptTime(_duration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string prompt = _prompts[random.Next(_prompts.Count())];
            Console.Write($"> {prompt} ");
            Pause(promptTime, false, true);
            Console.WriteLine();
        }
    }
    private int GetPromptTime(int duration)
    {
        int promptCount = duration / 15; // 15 is the target breath length
        if (promptCount == 0)
        {
            promptCount = 1;
        }
        int promptDuration = duration / promptCount; // Gets as close to 15 seconds as possible
        return promptDuration;  
    }


}