namespace Task1C;

public class Employee
{
    public string Name { get; set; } = "";
    public int Salary { get; set; } = 0;

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }
    public double CalculateBonus()
    {
        return Salary * 0.1;
    }
}