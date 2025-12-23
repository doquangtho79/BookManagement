using BookManagement.Controllers;
using BookManagement.Models;

namespace BookManagement.Data
{
    public static class BookRepository
    {
        private static List<Book> books = new()
        {
            new Book{ Id = 1, Title = "Doremon", Author = "Kenzo" },
            new Book{ Id = 2, Title = "Cuốn theo chiều gió", Author = "Rivado"}
        
        };
        private static int nextId = 3;
        public static List<Book> GetAll() => books;

    public static void Add(Book book)
        {
            book.Id = nextId++;
            books.Add(book);            
        }
    }
}
