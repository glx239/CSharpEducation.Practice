namespace Task11;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Author = "Teodor Dryzer";
        book.Title = "Financier";
        PrintBook(book);

    }

    static void PrintBook(Book book)
    {
        Console.WriteLine(book.Title +  " " + book.Author);
    }
}