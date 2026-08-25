using BooksAPI.Models;

namespace BooksAPI.Data
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>
        {

            new Book { Author = "Robert C. Martin", Title = "Clean Code" },
            new Book { Author = "Martin Fowler", Title = "Refactoring" },
            new Book { Author = "Andrew Hunt", Title = "The Pragmatic Programmer" },
            new Book { Author = "Eric Evans", Title = "Domain-Driven Design" },
            new Book { Author = "Gang of Four", Title = "Design Patterns" }

       };
    }
}
