using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals= new List<Goal>();
        _score= 0;
    }
    public void Start()
    {
        int option=0;
        while (option !=6)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List of Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            option= int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (option== 1)
            {
                CreateGoal();
            }
            else if (option== 2)
            {
                ListGoalDetails();
            }
            else if (option== 3)
            {
                SaveGoals();
            }
            else if (option== 4)
            {
                LoadGoals();
            }
            else if (option== 5)
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points in total");
    }
    public void ListGoalNames()
    {
        for (int i=0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}, {_goals[i].GetShortName()}");
        }
        Console.WriteLine($"Press Enter to continue...");
        Console.ReadLine();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals: ");
        for (int i=0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}, {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"Press Enter to continue...");
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("Menu of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose your goal: ");
        int choose= int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name= Console.ReadLine();
        Console.Write("Description: ");
        string description= Console.ReadLine();
        Console.Write("Points: ");
        int points= int.Parse(Console.ReadLine());

        if (choose==1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choose==2)
        {
            _goals.Add(new EternalGoal(name,description,points));
        }
        else if (choose==3)
        {
            Console.Write("Target count: ");
            int target= int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus= int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name,description,points,target,bonus));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplis? ");
        int index= int.Parse(Console.ReadLine()) -1;
        Console.WriteLine();
        int earned= _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        Console.Write("Set a name for the file: ");
        string filename= Console.ReadLine();
        using (StreamWriter output= new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        string filename= Console.ReadLine();
        string[] lines= File.ReadAllLines(filename);
        _score= int.Parse(lines[0]);
        _goals.Clear();
        for (int i=1; i < lines.Length; i++)
        {
            string[] parts= lines[i].Split("|");
            string type= parts[0];

            if (type=="Simple")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type=="Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type=="Checklist")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
    }
}