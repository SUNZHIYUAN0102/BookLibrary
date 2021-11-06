using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public string Picture { get; set; }

        public ICollection<MyBook> MyBooks { get; set; }
    }
}
