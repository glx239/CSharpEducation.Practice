namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        CreateName(student);
    }

    static void CreateName(Student student)
    {
        student.Name = "Аноним";
        Console.WriteLine(student.Name);
    }
}