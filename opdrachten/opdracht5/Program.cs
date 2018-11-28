using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Author bookAuthor = new Author("Nawang Tendar", "lala@gmail.com", 'M');
            Book book = new Book("See Future", bookAuthor, 999.8, 5);
            book.print();
        }
    }
}
