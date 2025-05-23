namespace Task25;

class Program
{
    enum DaysWeek : int
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    static void Main(string[] args)
    {
        Console.WriteLine((DaysWeek)Convert.ToInt32(Console.ReadLine()));
    }
}