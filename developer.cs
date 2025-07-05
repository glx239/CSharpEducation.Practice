

using System;

namespace employee_monitoring_system;

public class Developer : IEmployee
{
    private string firstname { get; set; }
    private string lastname {  get; set; }
    private string birthdate { get; set; }
    private string phone { get; set; }
    private string hobby { get; set; }
    private int salary = 50000;
    public string tittle { get; set; }
    
    
    void string ViewSalary()
    {
        
        Console.Write("Enter your salary: ");
    }
}