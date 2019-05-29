using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary
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
            PrintBooks(library);
        }

        private static void PrintBooks(Library library)
        {
            var ordered = library.BooksList.GroupBy(x => x.Author)
                        .Select(g => new
                        {
                            Author = g.Key,
                            Prices = g.Sum(s => s.Price)
                        })
                        .OrderByDescending(x => x.Prices)
                        .ThenBy(x => x.Author)
                        .ToList();

            foreach (var author in ordered)
            {
                Console.WriteLine($"{author.Author} -> {author.Prices:f2}");
            }
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