using System;

namespace Task1A;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Evgen", 100);
        Manager mgr = new Manager("Dimid", 100);
        Console.WriteLine(emp.CalculateBonus());
        Console.WriteLine(mgr.CalculateBonus());
        Console.WriteLine(emp.CalculateBonus());
    }   
}