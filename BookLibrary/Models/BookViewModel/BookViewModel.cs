using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models.BookViewModel
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public IEnumerable<MyBook> MyBooks { get; set; }
    }
}
