namespace Task5;

class Book
{
    public string title;
    public string author;
    public int yearofpublication;

    public Book() : this("new book")
    { }

    public Book(string title) : this(title, "new author")
    { }
    
    public Book(string title, string author) : this(title, author, 2025)
    { }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.yearofpublication = year;
    }
    
    public void Print()
    {
        Console.WriteLine($"{title}, {author},  {yearofpublication}");
    }}