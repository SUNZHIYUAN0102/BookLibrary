using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class MyBook
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public Guid BookId { get; set; }

        public Book Book { get; set; }
    }
}
