using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.BookViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly UserManager<User> userManager;

        public BooksController(ApplicationDbContext dbcontext, UserManager<User> userManager)
        {
            this.dbcontext = dbcontext;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index(ManageMessageId? message = null)
        {
            this.ViewData["StatusMessage"] =
                message == ManageMessageId.AddBookSuccessfully ? "You add this book to your reading list successfully."
                : message == ManageMessageId.RemoveBookSuccessfully ? "You remove this book from your reading list successfully."
                    : "";

            var user = await this.userManager.GetUserAsync(this.HttpContext.User);
            var books = await this.dbcontext.Books.Include(x=>x.MyBooks).ToListAsync();
            var mybooks = this.dbcontext.MyBooks.Include(x => x.Book).Where(x => x.User == user).AsEnumerable();
            return View(new BookViewModel { Books = books, MyBooks = mybooks});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBook(Guid? bookId)
        {
            if(bookId == null)
            {
                return NotFound();
            }

            var book = await this.dbcontext.Books.SingleOrDefaultAsync(x => x.Id == bookId);

            if(book == null)
            {
                return NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    var user = await this.userManager.GetUserAsync(this.HttpContext.User);
                    var mybook = new MyBook
                    {
                        BookId = book.Id,
                        User = user
                    };
                    this.dbcontext.MyBooks.Add(mybook);
                    await this.dbcontext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index), new { Message = ManageMessageId.AddBookSuccessfully });
                }
                catch (Exception e)
                {
                    return View("Error");
                }

            }
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveBook(Guid? bookId)
        {
            if (bookId == null)
            {
                return NotFound();
            }

            var book = await this.dbcontext.Books.SingleOrDefaultAsync(x => x.Id == bookId);

            if (book == null)
            {
                return NotFound();
            }

            var user = await this.userManager.GetUserAsync(this.HttpContext.User);

            var mybook = await this.dbcontext.MyBooks.SingleOrDefaultAsync(x => x.BookId == book.Id && x.UserId == user.Id);

            if(mybook == null)
            {
                return NotFound();
            }

            this.dbcontext.MyBooks.Remove(mybook);
            await this.dbcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { Message = ManageMessageId.RemoveBookSuccessfully });
        }

        public enum ManageMessageId
        {
            AddBookSuccessfully,
            RemoveBookSuccessfully
        }
    }
}
