public class CheckList : Goal
{
    int _completeGoal;

    public CheckList()
    {}
    public CheckList(int points, string name ,string descritption,int completeGoal,int completeCount)
    {
        _goalType = "checklist";
        _name=name; 
        _description=descritption;
        _pointValue=points;
        _completeCount=completeCount;
        _completeGoal=completeGoal;
    }
    public override Goal PromptGoalInfo()
    {
        Console.WriteLine("what is the name of your checklist goal?");
        string name= Console.ReadLine();

        Console.WriteLine("give a quick description of the goal you are making ");
        string description=Console.ReadLine();

        Console.WriteLine("how many points is this goal worth");
        int points =int.Parse(Console.ReadLine());

        Console.WriteLine("how many times does this goal need to be completed?");
        int completeGoal = int.Parse(Console.ReadLine());

        Goal checklist = new CheckList(points,name, description, 0,completeGoal);
        return checklist;
    }
    public override void CompleteGoal()
    {
        _completeCount++;
        if(_completeCount >= _completeGoal)
        {
            _checkBox="[x]";
        }
    }
    public override int GetCompleteGoal()
    {
        return _completeGoal;
    }
    public override int GetpointValue()
    {
        if (_completeCount >= _completeGoal)
        {
            return _pointValue;
        }
        else 
        {
            return _pointValue;
        }
    }


}