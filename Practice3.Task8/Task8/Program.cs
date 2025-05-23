namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();
        r1.height = 5;
        r1.width = 10;
        Console.WriteLine(r1.Area());
        Rectangle r2 = new Rectangle();
        r2.height = 7.4;
        r2.width = 3.74;
        Console.WriteLine(r2.Area());
    }
}