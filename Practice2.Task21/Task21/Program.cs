namespace Task21;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = rnd.Next(1, 100);
        GuessOfNumber(n);
    }

    static void GuessOfNumber(int n)
    {
        Console.WriteLine("Добро пожаловать в угадай число\nПравила просты, вводите число пока не получите верное");
        while (true)
        {
            Console.Write("Введите число: ");
            int solution =  Convert.ToInt32(Console.ReadLine());
            if (solution == n)
            {
                Console.WriteLine("Поздравляю вы ответили верно");
                break;
            }
        }
    }
}