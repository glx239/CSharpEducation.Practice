using System;

namespace PhoneBook;

class Program
{
    static void Main(string[] args)
    {
        Phonebook phonebook = Phonebook.GetInstance();
        int key = -1;
        Start(phonebook, key);
    }

    static void Start(Phonebook phonebook, int key)
    {
        while (key != 0)
        {
            Console.WriteLine(@"Меню книжки:
    1. Добавить контакт
    2. Удалить контакт по номеру
    3. Найти контакт по номеру
    4. Найти номер телефона
    5. Вывести всю книгу
    0. выход");
            key = Convert.ToInt32(Console.ReadLine());
            if (key == 1)
            {
                Abonent ab = new Abonent();
                string? name = Console.ReadLine();
                string? phone = Console.ReadLine();
                ab.name = name;
                ab.phone = phone;
                phonebook.AddContact(ab);
            }
            else if (key == 2)
            {
                string? number = Console.ReadLine();
                phonebook.DeleteContact(number);
            }
            else if (key == 3)
            {
                string?  number = Console.ReadLine();
                phonebook.ReturnNameForNumber(number);
            }
            else if (key == 4)
            {
                string?  name = Console.ReadLine();
                phonebook.ReturnNumberForName(name);
            }
            else if (key == 5)
            {
                phonebook.ViewContact();
            }
            else if (key == 0)
            {
                return;
            }
        }
        phonebook.ToFile();
    }
}