using System.ComponentModel;
using System.Drawing;

public abstract class Goal
{
    protected int _pointValue;
    protected string _name; 
    protected string _description;
    protected string _checkBox ="[ ]";
    protected int _completeCount;
    protected  string _goalType;
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual string Getcomplete()
    {
        return _checkBox;
    }
    public virtual int GetpointValue()
    {
        return _pointValue;
    }

    public abstract Goal PromptGoalInfo();
    public abstract void CompleteGoal();
    public virtual int GetCompleteCount()
    {
        return _completeCount;
    }
    public virtual int GetCompleteGoal()
    {
        return 0;
    }
}