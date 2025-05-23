namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.name = "Rendle";
        student.age = 37;
        student.Average = 125.0 / 30.0;
        Console.WriteLine(student.Average);
    }
}