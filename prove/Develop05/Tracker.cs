using System.Configuration.Assemblies;

public class GoalTracker
{
    private string userName;
    private List<Goal> goals = new List<Goal>();

    private int points=0;

    public int GetPoints()
    {
        return points;
    }public void promptSave()
    {
        Console.WriteLine("what file would you liek to save your goals to?");
        string fileName= Console.ReadLine();
        SaveGoals(fileName);
    }
    public void SaveGoals(string fileName)
    {
        using(StreamWriter outputFile = new StreamWriter(fileName, append : true))
        {
            outputFile.WriteLine($"{userName}");
            outputFile.WriteLine($"{points}");
            foreach(Goal goal in goals)
            {
                switch (goal.GetGoalType())
                {
                     case "Simple":
                        outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}|{goal.GetCompletionStatus()}");
                        break;
                    case "Eternal":
                        outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}|{goal.GetCompletionCount()}|{goal.GetCompletionStatus()}");
                        break;
                    case "Checklist":
                        outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}|{goal.GetCompletionCount()}|{goal.GetCompletionGoal()}|{goal.GetBonus()}|{goal.GetCompletionStatus()}");
                        break;
                }
            }
        }
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetName()} - {goal.GetDescription()}");
        }
    }
     public void RecordProgress()
    {
        DisplayGoals();
        Console.WriteLine("Which goal would you like to record progress for?");
        int goalNumber = int.Parse(Console.ReadLine());
        Goal selectedGoal = goals[goalNumber - 1];
        string goalType = selectedGoal.GetGoalType();
        switch (goalType)
        {
            case "Simple":
                selectedGoal.CompleteGoal();
                points += selectedGoal.GetpointValue();
                break;
            case "Eternal":
                selectedGoal.CompleteGoal();
                points += selectedGoal.GetpointValue();
                break;
            case "Checklist":
                selectedGoal.CompleteGoal();
                points += selectedGoal.GetpointValue();
                break;
        }
        Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetPointValue()} points!");
        Console.WriteLine($"You now have {points} points.");
    }

}