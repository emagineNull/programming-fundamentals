using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibraryModification
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> BooksList = new List<Book>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Library library = new Library();
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                Book book = ReadBook();
                books.Add(book);
            }
            library.BooksList = books;
            DateTime targetDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var bookReleasedAfter = GetBooksReleasedAfterDate(library, targetDate);
            PrintTotalBooksPriveByAuthor(bookReleasedAfter);
        }

        static void PrintTotalBooksPriveByAuthor(Dictionary<string, DateTime> booksReleasedAfterDate)
        {
            foreach (var date in booksReleasedAfterDate.OrderBy(d => d.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{date.Key} -> {date.Value:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> GetBooksReleasedAfterDate(Library libraryOfBooks, DateTime targetDate)
        {
            var totalBooksPriveByAuthor = new Dictionary<string, DateTime>();
            foreach (var book in libraryOfBooks.BooksList)
            {
                if (targetDate < book.ReleaseDate)
                {

                    totalBooksPriveByAuthor[book.Title] = book.ReleaseDate;


                }
            }

            return totalBooksPriveByAuthor;
        }

        private static Book ReadBook()
        {
            var bookInfo = Console.ReadLine().Split(' ').ToArray();
            Book book = new Book
            {
                Title = bookInfo[0],
                Author = bookInfo[1],
                Publisher = bookInfo[2],
                ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = bookInfo[4],
                Price = decimal.Parse(bookInfo[5])
            };

            return book;
        }
    }
}