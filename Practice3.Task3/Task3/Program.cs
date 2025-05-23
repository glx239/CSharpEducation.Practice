namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.Add(1, 2);
        calc.Sub(3, 4);
        calc.Mul(5, 6);
        calc.Div(3, 2);
    }
}