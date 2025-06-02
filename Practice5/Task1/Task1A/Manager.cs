namespace Task1A;

public class Manager : Employee
{
    
    private int TeamSize;
    public Manager(string name, int salary, int teamsize) : base(name, salary)
    {
        TeamSize = teamsize;
    }

    public override double CalculateBonus()
    {
        return TeamSize > 5 ? (Salary * 0.25) : (Salary * 0.2);
    }
}