using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBook;

/// <summary>
/// Класс Phonebook
/// </summary>
public class Phonebook
{
    private static Phonebook instance;
    private List<Abonent> abonents;
    private string filename = "phonebook.txt";

    /// <summary>
    /// Приватный конструктор для создания объекта
    /// </summary>
    private Phonebook()
    {
        abonents = new List<Abonent>();
    }

    /// <summary>
    /// Синглтон для создания одного экземпляра класса, если экземпляр не создан, создает его
    /// и вызывает приватный конструктор класса
    /// </summary>
    /// <returns></returns>
    public static Phonebook GetInstance()
    {
        if (instance == null)
        {
            instance = new Phonebook();
            instance.FromFile();
        }
        return instance;
    }
    
    /// <summary>
    /// Публичное свойство для вывода контактов в записной книжке
    /// </summary>
    public void ViewContact()
    {
        for (int i = 0; i < abonents.Count; i++)
        {
            Console.WriteLine(abonents[i].name + " : " + abonents[i].phone);
        }
    }
    
    /// <summary>
    /// Публичное свойство. Добавляет контакт в записную книжку
    /// </summary>
    /// <param name="abonent"></param>
    public void AddContact(Abonent abonent)
    {
        abonents.Add(abonent);
    }

    /// <summary>
    /// Публичное свойство. Удаляет контакт из записной книжки
    /// </summary>
    /// <param name="phone"></param>
    public void DeleteContact(string phone)
    {
        for (int i = 0; i < abonents.Count; i++)
        {
            if (abonents[i].phone == phone)
            {
                Console.WriteLine($"Контакт {abonents[i].name} c номером {phone} удален");
                abonents.Remove(abonents[i]);
                return;
            }
        }
        Console.WriteLine($"Номер {phone} не найден, попробуйте снова...");
    }
    
    /// <summary>
    /// Публичное свойство. Возвращает имя контакта из записной книжки по номеру телефона
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    public string ReturnNameForNumber(string phone)
    {
        for (int i = 0; i < abonents.Count; i++)
        {
            if (abonents[i].phone == phone)
            {
                return abonents[i].name;
            }
        }

        return "Номер не заведен";
    }
    
    /// <summary>
    /// Публичное свойство. Возвращает номер телефона контакта из записной книжки по имени абонента
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public string ReturnNumberForName(string name)
    {
        for (int i = 0; i < abonents.Count; i++)
        {
            if (abonents[i].name == name)
            {
                return abonents[i].phone;
            }
        }
        return "Абонента нет";
    }

    /// <summary>
    /// Публичное свойство. Записывает данные в файл.
    /// </summary>
    ///  
    public void ToFile()
    {
        try
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (Abonent abonent in abonents)
            {
                writer.WriteLine(abonent.name +  " : " + abonent.phone);
            }
            writer.Close();
        }
        catch (Exception e)
        {
            return;
        }
        
    }
    
    /// <summary>
    /// Приватное свойство. Вначале программы, при создании класса Phonebook, выгружает из файла ранее сохраненные контакты.
    /// </summary>
    private void FromFile()
    {
        StreamReader reader = new StreamReader(filename);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(" : ");
            Abonent ab = new Abonent();
            ab.name = parts[0];
            ab.phone = parts[1];
            abonents.Add(ab);
        }
        reader.Close();
    }
    
    
}