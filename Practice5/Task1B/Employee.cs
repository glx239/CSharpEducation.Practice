using System;

namespace Task1B;

public class Employee
{
    public string Name { get; set; } = "";
    public int Salary { get; set; } = 0;

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }
    public virtual double CalculateBonus()
    {
        return Salary * 0.1;
    }
}