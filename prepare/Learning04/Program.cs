using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments a1 = new Assignments("math","mckayla");
        Console.WriteLine( a1.GetSummary());

        Math a2 = new Math("derivatives","2-10","math", "mckayla");
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine(a2.GetSummary());

        Reading a3 = new Reading("the holocost ","mckayla","reading");
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine(a3.GetSummary());
    }
}