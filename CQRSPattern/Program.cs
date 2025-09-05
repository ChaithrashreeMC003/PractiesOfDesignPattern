using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new LibraryService();

            library.BorrowBook(2);       // Command
            library.GetBookDetails(2);  // Query
            library.GetBookDetails(1);  // Query
            library.BorrowBook(2);       // Command - already borrowed
        }
    }
}
