Console.WriteLine("Введите значения и знак сравнения");
string? word = Console.ReadLine();

string[] words = word.Split(new char[] {' '});
int a = Convert.ToInt32(words[0]);
int b = Convert.ToInt32(words[2]);
string oper = words[1];
switch(oper)
{
    case ">":
        Console.WriteLine(a > b);
        break;
    case "<":
        Console.WriteLine(a < b);
        break;
    case "=":
        Console.WriteLine(a == b);
        break;
    case "!=":
        console.WriteLine(a != b);
        break;  
}
