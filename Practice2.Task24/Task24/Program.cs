namespace Task24;

class Program
{
    enum DaysWeekEN
    {
        Monday,
        Tuesday,
        Wensday,
        Thursday,
        Friday,
        Saturday,
        Sunday    
    }

    enum DaysWeekRU
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    static void Main(string[] args)
    {
        Console.Write("Введите формат языка если 0, то английский, если 1, то русский: ");
        int language = Convert.ToInt32(Console.ReadLine());
        if (language == 0)
        {
            foreach (var day in Enum.GetValues(typeof(DaysWeekEN)))
            {
                Console.WriteLine(day);
            }    
        }
        else
        {
            foreach (var day in Enum.GetValues(typeof(DaysWeekRU)))
            {
                Console.WriteLine(day);
            }
        }
    }


}