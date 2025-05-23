namespace Task22;

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
        int timer = 0;
        Console.WriteLine("Добро пожаловать в угадай число\nПравила просты, вводите число пока не получите верное");
        while (true)
        {
            if (timer == 10)
            {
                Console.WriteLine("Игра окончена\n Вы проиграли мухаха");
                break;
            }

            Console.Write("Введите число: ");
            int solution = Convert.ToInt32(Console.ReadLine());
            if (solution == n)
            {
                timer++;
                Console.WriteLine($"Поздравляю вы ответили верно с {timer} попытки");
                break;
            }
            else if (solution > n)
            {
                Console.WriteLine("Число больше загаданого");
            }
            else if (solution < n)
            {
                Console.WriteLine("Число меньше загаданного");
            }

            timer++;
        }
    }
}