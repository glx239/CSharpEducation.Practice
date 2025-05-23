int ab = 0;
int ac = 0;
int bc = 0;

Console.WriteLine("Программа находит гипотенузу по двум катетам или катет по гипотенузе и катету");
Console.WriteLine("Введите кнопку: 1. находим гипотенузу, 2. находим катет");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1){
    Console.WriteLine("Введите катеты:");
    ab = Convert.ToInt32(Console.ReadLine());
    ac = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Гипотенуза равна: " + (Math.Sqrt(ab * ab + ac * ac)));
}
else{
    Console.WriteLine("Введите катет и гипотенузу:");
    ab = Convert.ToInt32(Console.ReadLine());
    bc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Катет равен: " + (Math.Sqrt(bc * bc - ab * ab)));
}