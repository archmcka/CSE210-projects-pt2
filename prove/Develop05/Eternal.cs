using System.Runtime.InteropServices.Marshalling;
public class Eternal : Goal
{
    public Eternal()
    {}
    public Eternal (string name, string description, int points)
    {
        _goalType = "eternal";
        _name = name;
        _description = description;
        _pointValue = points;
        _completeCount=0;
    }
    public override Goal PromptGoalInfo()
    {
        Console.WriteLine("what is the name of your eternal goal?");
        string name= Console.ReadLine();

        Console.WriteLine("give a quick description of the goal you are making ");
        string description=Console.ReadLine();

        Console.WriteLine("how many points is this goal worth");
        int pointvalue=int.Parse(Console.ReadLine());

        Goal eternal = new Eternal( name, description, pointvalue);
        return eternal;
    }
    public override string Getcomplete()
    {
        return $"{_checkBox}";
    }
    public void SetCount(int count)
    {
        _completeCount=count;
    }
}