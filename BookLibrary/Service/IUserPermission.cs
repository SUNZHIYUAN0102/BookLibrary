using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Service
{
    public interface IUserPermission
    {
        Boolean CanAddBook(Book book);
    }
}
