using Person;

namespace CreatePerson;

class Program
{
    static void Main(string[] args)
    {
        Person.Person person = new Person.Person();
        person.name = "Anton";
        person.age = 27;
        person.Print();
    }
}