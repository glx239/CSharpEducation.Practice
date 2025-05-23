namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        string title = "Harry Potter and the  Philosopher's Stone";
        string author = "Joan Rowling";
        int year = 1997;
        Book book = new Book();
        Book book2 = new Book(title);
        Book book3 = new Book(title, author);
        Book book4 = new Book(title, author,  year);
        book.Print();
        book2.Print();
        book3.Print();
        book4.Print();
    }
}