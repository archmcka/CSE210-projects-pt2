class Listing : Activity
{
    private List<string>_prompts=
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private int _responseCount;

    public Listing() : base("listing", "this activity will help you reflect on the good things in life by having you write out as many things as you can for each prompt .")
    {
    }
    
    public void Start()
    {
        GetStartingMessage();
        _duration=GetDuration();
        Prepare();
        ShowPrompt();
        countResponses();
        EndingMessage();
    }
    
    public void ShowPrompt()
    {
        Random random= new Random();
        string prompt=_prompts[random.Next(_prompts.Count)];
        Console.WriteLine("list as many answer as you can in the ammount of time that you have");
        Console.WriteLine(prompt);
        Console.WriteLine ("you may begin");
        Pause (3,true,false);
        Console.Clear();
        Console.WriteLine(prompt);
    }
    private void countResponses()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _responseCount++;
        }
    }

}