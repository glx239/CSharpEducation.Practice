

namespace Task1A;

public class Manager : Employee
{
    public Manager(string name, int salary) : base(name, salary)
    {
        
    }

    public override double CalculateBonus()
    {
        return Salary * 0.2;
    }
}