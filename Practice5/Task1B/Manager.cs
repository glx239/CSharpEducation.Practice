namespace Task1B;

public class Manager : Employee
{
    public int TeamSize { get; set; } = 0;
    
    public Manager(string name, int salary, int teamsize) : base(name, salary)
    {
        TeamSize = teamsize;
    }

    public override double CalculateBonus()
    {
        if (TeamSize > 5)
        {
            return Salary * 0.25;
        }
        return Salary * 0.2;
    }
    
}
