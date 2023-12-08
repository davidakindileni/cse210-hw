using System;

public abstract class Goal
{
    // define member variables
    private string _type;
    private string _name;
    private string _desc;
    private int _points;


    // define constructors
    public Goal(string type, string name, string desc, int points)
    {
        _type = type;
        _name = name;
        _desc = desc;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDesc()
    {
        return _desc;
    }
    public int GetPoints()
    {
        return _points;
    }


    // define methods
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);

}