Console.WriteLine("for");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("while");

int count = 0;

while (count < 10)
{
    Console.WriteLine(count);
    count++;
}

Console.WriteLine("do while");

do
{
    Console.WriteLine(count);
    count--;
}
while (count > 0);


string words = "";

for (int i = 0; i < 10; i++)
{
    words += Console.ReadLine() + " ";
}

Console.WriteLine(words);

string words_while = "";

while (count < 10)
{
    words_while += Console.ReadLine() + " ";
    count++;
}

Console.WriteLine(words_while);

string words_do_while = "";

do
{
    words_while += Console.ReadLine() + " ";
    count--;
}
while (count > 0);

Console.WriteLine(words_do_while);