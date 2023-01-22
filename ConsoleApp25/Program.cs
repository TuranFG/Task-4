using System;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookOverRide();


        }
        static void BookOverRide()
        {
            Console.Write("A number of books: ");
            int n = int.Parse(Console.ReadLine());
            Book[] books = new Book[n];

            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                Console.Write($"{i + 1}. Book Name: ");
                book.Name = Console.ReadLine();
                Console.Write($"{i + 1}. Author Name: ");
                book.AuthorName = Console.ReadLine();
                Console.Write($"{i + 1}. Published Date: ");
                book.PublishedDate = int.Parse(Console.ReadLine());
            l1: Console.Write($"{i + 1}. Page Count: ");
                book.PageCount = int.Parse(Console.ReadLine());
                if (book.PageCount > 10 == false)
                {
                    Console.WriteLine("Page numer is more than this ");
                    goto l1;
                }
                Console.WriteLine();

                books[i] = book;
            }


            foreach (var item in books)
            {
                Console.WriteLine(item);
            }

        }

        static void Book2()
        {

            Console.Write("A number of books: ");
            int n = int.Parse(Console.ReadLine());
            Book2[] books = new Book2[n];

            for (int i = 0; i < n; i++)
            {
                Book2 book = new Book2();
                Console.Write($"{i + 1}. Book Name: ");
                book.Name = Console.ReadLine();
                Console.Write($"{i + 1}. Author Name: ");
                book.AuthorName = Console.ReadLine();
                Console.Write($"{i + 1}. Published Date: ");
                book.PublishedDate = int.Parse(Console.ReadLine());
            l1: Console.Write($"{i + 1}. Page Count: ");
                book.PageCount = int.Parse(Console.ReadLine());
                if (book.PageCount > 10 == false)
                {
                    Console.WriteLine("Page numer is more than this ");
                    goto l1;
                }
                Console.WriteLine();

                books[i] = book;

                Console.WriteLine($"Book Name: {book.Name}");
                Console.WriteLine($"Author Name: {book.AuthorName}");
                Console.WriteLine($"Published Date: {book.PublishedDate}");
                Console.WriteLine($"Page Count: {book.PageCount}");
                Console.WriteLine();

            }
                 


        }

    }
}