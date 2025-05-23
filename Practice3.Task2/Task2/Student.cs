namespace Task2;

public class Student
{
    public string name;
    public int age;
    private double average;
    
    public double Average
    {
        get { return average; }
        set
        {
            if (0 <= value && value <= 5)
            {
                average = value;
            }
            else
            {
                Console.WriteLine("Неподходящее значение");
            }
        }
    }
    
    public void StudentInformation()
    {
        Console.WriteLine($"Имя студента: {name}\nВозраст студента: {age}");
        
    }
}