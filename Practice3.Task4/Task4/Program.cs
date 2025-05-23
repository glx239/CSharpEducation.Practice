namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        Book book2 = new Book(t:"Harry Potter and the Philosopher's Stone", a:"Joan Rowling");
        book.Print();
        book2.Print();
    }
}