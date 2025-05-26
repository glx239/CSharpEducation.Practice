namespace Task1C;

public class Contractor : Employee
{
    public int HourlyRate { get; set; }

    public Contractor(string name, int salary, int hourlyrate) : base(name, salary)
    {
        HourlyRate = hourlyrate;
    }

    public new double CalculateBonus(double HoursWorked)
    {
        return HourlyRate * HoursWorked;
    }
 }