using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class User : IdentityUser
    {
        public ICollection<MyBook> MyBooks { get; set; }
    }
}
