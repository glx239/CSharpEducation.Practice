namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        month = (Months)Enum.Parse(typeof(Months), Console.ReadLine());
        Console.WriteLine(Months.month);
    }


}