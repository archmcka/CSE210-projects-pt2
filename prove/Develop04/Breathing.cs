class Breathing : Activity
{
    private int _breathTime;

     public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {
    }
    public void Start()
    {
        GetStartingMessage();
        int duration = GetDuration();
        _breathTime= GetBreathTime(duration);
        Prepare();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Pause(_breathTime, true, false);
            Console.Write("\nNow breathe out...");
            Pause(_breathTime, true, false);
            Console.WriteLine("\n");
        }

        EndingMessage();
    }
    private int GetBreathTime(int durration)
    {
        int breath=durration/6;
        if (breath == 0)
        {
            breath=1;
        }
        int breathDuration = durration/ breath;
        if (breathDuration > 6)
        {
            breathDuration -= 5;
        }
        return breath;

    }
}