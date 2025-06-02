using System;
using System.Collections.Generic;

namespace Task1A;

class Program
{
    static void Main(string[] args)
    {
        Employee first = new Employee("Anton", 300);
        Employee second = new Employee("Rinat", 250);
        Employee third = new Employee("Drake", 1000);
        Manager four = new Manager("Kate", 500, 3);
        Manager five = new Manager("James", 1220, 5);
        Manager six = new Manager("Ivan", 14800, 0);
        Contractor seven = new Contractor("Petr", 4200, 32);
        Contractor eight = new Contractor("Evgen", 322, 15);
        Contractor nine = new Contractor("Nina", 100, 72);
        Console.WriteLine(nine.CalculateBonus(10));
        List<Employee> coworkers = [first, second, third, four, five, six, seven, eight, nine];

        
        foreach (var coworker in coworkers)
        {
            if (coworker is Contractor)
            {
                Contractor contractor = (Contractor)coworker;
                Console.WriteLine(contractor.CalculateBonus(32));
            } 
            Console.WriteLine(coworker.CalculateBonus());
        }
        
        
    }
}