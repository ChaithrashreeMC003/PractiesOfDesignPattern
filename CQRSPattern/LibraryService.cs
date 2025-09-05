using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern
{
    public class LibraryService
    {
        private readonly List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Title = "C Sharp Basics", IsBorrowed = false },
        new Book { Id = 2, Title = "Design Patterns", IsBorrowed = false },
        new Book { Id = 3, Title = "LINQ in Action", IsBorrowed = false }
    };

    // Command: Borrow a book
    public void BorrowBook(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId);
        if (book == null)
            {
                Console.WriteLine("Book not found");
            return;
        }
            if (book.IsBorrowed)
            {
                Console.WriteLine($"Book '{book.Title}' is already borrowed");
                return;
            }
            book.IsBorrowed = true;
            Console.WriteLine($"Book '{book.Title}' has been borrowed successfully!");
    }

        // Query: Get book details
        public void GetBookDetails(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
        }
            string status = book.IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"Book {book.Id}: '{book.Title}' - {status}");
        }
    }
}
