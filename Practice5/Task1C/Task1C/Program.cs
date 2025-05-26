using System;

namespace Task1C;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Rodrigo", 350);
        Contractor con = new Contractor("Boris", 380, 380);
        Console.WriteLine(con.CalculateBonus(401));
        Contractor emp1 = (Contractor)emp;
        emp1.HourlyRate = 300;
        Console.WriteLine(emp1.CalculateBonus(402));
    }
}
