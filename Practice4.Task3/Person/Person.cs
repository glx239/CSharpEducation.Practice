namespace Person;

public class Person
{
    public string name;
    public int age;
    public Person() : this("Noname")
    { }
    public Person(string name) : this (name, 7)
    { }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}