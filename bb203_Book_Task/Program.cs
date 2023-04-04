namespace bb203_Book_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("qorxu", "bdu", "bb203", 1, 10);
            Book book2 = new Book("qor", "bd", "bb2", 4, 3);
            Book book3 = new Book("qorx", "bdu", "bb20", 2, 4);
            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}