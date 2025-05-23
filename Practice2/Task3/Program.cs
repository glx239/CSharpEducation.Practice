Console.WriteLine("Введите по очереди a, b, f");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine((a + b - f / a) + f * a * a - (a + b));
}
catch
{
    Console.WriteLine("деление на ноль)");
}