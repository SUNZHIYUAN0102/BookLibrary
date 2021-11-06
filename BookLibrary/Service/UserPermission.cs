using BookLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Service
{
    public class UserPermission : IUserPermission
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<User> userManager;

        public UserPermission(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }
        public Boolean CanAddBook(Book book)
        {
            var currentUser = this.userManager.GetUserId(this.httpContextAccessor.HttpContext.User);
            foreach(var item in book.MyBooks)
            {
                if(item.UserId == currentUser)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }
    }
}
