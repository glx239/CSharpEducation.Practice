using Practice4.Task1;

namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        MathHelper objMathHelper = new MathHelper();
        objMathHelper.ArgFirst = 5;
        objMathHelper.ArgSecond = 15;
        Console.WriteLine(objMathHelper.Add());
        Console.WriteLine(objMathHelper.Subtract());
        Console.WriteLine(objMathHelper.Multiply());
        Console.WriteLine(objMathHelper.Divide());
    }
}