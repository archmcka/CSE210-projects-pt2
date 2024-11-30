using System.Runtime.InteropServices.Marshalling;

public class Simple : Goal
{
    public Simple(){}
    public Simple (int points, string name ,string descritption)
    {
        _goalType = "simple";
        _name=name; 
        _description=descritption;
        _pointValue=points;
    }
    public override Goal PromptGoalInfo()
    {
        Console.WriteLine("what is the name of your goal");
        string name = Console.ReadLine();

        Console.WriteLine("what is a quick description of this goal?");
        string description = Console.ReadLine();

        Console.WriteLine ("what is the point value of this goal?");
        int points =int.Parse(Console.ReadLine());

        Goal simple = new Simple(points,name, description);
        return simple;
    }
    public override void CompleteGoal()
    {
        _checkBox ="[x]";
    }

}