
namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Dot dot1 = new Dot(10, 10);
        Dot dot2 = new Dot(7, 4);
        Console.WriteLine(DistanceDots(dot1, dot2));
    }

    static double DistanceDots(Dot dot1, Dot dot2)
    {
        return Math.Sqrt(Math.Pow(dot2.x - dot1.x, 2) + Math.Pow(dot2.y - dot1.y, 2));
    }
}