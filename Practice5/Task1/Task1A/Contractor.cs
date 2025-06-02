
namespace Task1A;

public class Contractor : Employee
{
    public double HourlyRate;

    public Contractor(string name, int salary, double hourlyRate) : base(name, salary)
    {
        HourlyRate = hourlyRate;
    }

    public double CalculateBonus(int hoursWorked)
    {
        return HourlyRate * hoursWorked;
    }
}