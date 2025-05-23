namespace Task3;

public class Calculator
{

    public void Add(int a, int b)
    {
        Console.WriteLine($"Сложение: {a + b}");
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine($"Вычитание: {a - b}");
    }

    public void Mul(int a, int b)
    {
        Console.WriteLine($"Умножение: {a * b}");
    }

    public void Div(int a, int b)
    {
        Console.WriteLine($"Деление: {a / b}");
    }
}