using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBook;

public class Phonebook
{
    private static Phonebook instance;
    private Dictionary<string, string> abonents;
    private string filename = "phonebook.txt";

    private Phonebook()
    {
        abonents = new Dictionary<string, string>();
    }

    public static Phonebook GetInstance()
    {
        if (instance == null)
        {
            instance = new Phonebook();
            instance.FromFile();
        }
        return instance;
    }

    public void ViewContact()
    {
        foreach (KeyValuePair<string, string> pair in abonents)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }

    public void AddContact(string name, string phone)
    {
        abonents.Add(name, phone);
    }
    
    

    public void ToFile()
    {
        try
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (KeyValuePair<string, string> pair in abonents)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
            writer.Close();
        }
        catch (Exception e)
        {
            return;
        }
        
    }
    
    private void FromFile()
    {
        StreamReader reader = new StreamReader(filename);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(" : ");
            abonents.Add(parts[0], parts[1]);
        }
        reader.Close();
    }
    
    
}