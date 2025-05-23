void Rectangle(int height, string sep="*")
{
    string s = sep;
    for (int i = 1; i <= height; i++)
    {
        Console.WriteLine(s);
        s += sep;
    }
    s = sep;
    for (int i = 1; i <= height; i++)
    {
        for (int j = i; j < height; j++)
            {
                Console.Write(" ");
            }
        Console.WriteLine(s);
        s += sep;
    }
}

Console.WriteLine("Меняем тип заполнения треугольника? да, нет:");
string? type = Console.ReadLine();
switch (type)
{
    case "да":
        Console.WriteLine("Введите высоту и тип:");
        int h = Convert.ToInt32(Console.ReadLine());
        string? sep = Console.ReadLine();
        Rectangle(h, sep);
        break;
    case "нет":
        Console.WriteLine("Введите высоту");
        Rectangle(Convert.ToInt32(Console.ReadLine()));
        break;
}
