namespace Task4;

class Book
{
    public string title;
    public string author;

    public Book()
    {
        title = "New book";
        author = "New author";
    }

    public Book(string t, string a)
    {
        title = t;
        author = a;
    }

    public void Print()
    {
        Console.WriteLine($"{title}, {author}");
    }
}