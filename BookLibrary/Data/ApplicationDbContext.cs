using BookLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<MyBook> MyBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyBook>()
                .HasKey(x => new { x.BookId, x.UserId });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Name = "2666",
                    Author = "Roberto Bolaño Ávalos",
                    Picture = "2666.jpg",
                    Content = "https://www.negrophonic.com/pdfs/Bolano,%20Roberto%20-%202666.pdf"
                },

                new Book
                {
                    Name = "Love in the Time of Cholera",
                    Author = "Gabriel García Márquez",
                    Picture = "LoveInTheTimeOfCholera.jpg",
                    Content = "https://giove.isti.cnr.it/demo/eread/Libri/sad/LoveInTheTimeOfCholera.pdf"
                },

                new Book
                {
                    Name = "The Great Gatsby",
                    Author = "Francis Scott Key Fitzgerald",
                    Picture = "TheGreatGatsby.jpg",
                    Content = "https://www.planetebook.com/free-ebooks/the-great-gatsby.pdf"
                },

                new Book
                {
                    Name = "Norwegian Wood",
                    Author = "Haruki Murakami",
                    Picture = "NorwegianWood.jpg",
                    Content = ""
                },

                new Book
                {
                    Name = "1984",
                    Author = "George Orwell",
                    Picture = "1984.jpg",
                    Content = "https://www.planetebook.com/free-ebooks/1984.pdf"
                },

                new Book
                {
                    Name = "To Live",
                    Author = "Yu Hua",
                    Picture = "ToLive.jpg",
                    Content = ""
                },

                new Book
                {
                    Name = "In Search of Lost time",
                    Author = "Marcel Proust",
                    Picture = "InSearchOfLostTime.jpg",
                    Content = "https://uberty.org/wp-content/uploads/2015/12/Proust-1.pdf"
                },

                new Book
                {
                    Name = "Doctor Zhivago",
                    Author = "Boris Pasternak",
                    Picture = "DoctorZhivago.jpg",
                    Content = "http://userfiles.educatorpages.com/userfiles/kmcmillan/Doctor%20Zhivago.pdf"
                },

                new Book
                {
                    Name = "La Nausee",
                    Author = "Jean-Paul Sartre",
                    Picture = "La Nausee.jpg",
                    Content = "http://www.kkoworld.com/kitablar/jan_pol_satr_urekbulanma-eng.pdf"
                },

                new Book
                {
                    Name = "The Raven",
                    Author = "Edgar Allan Poe",
                    Picture = "TheRaven.jpg",
                    Content = "https://www.ibiblio.org/ebooks/Poe/Raven.pdf"
                },

                new Book
                {
                    Name = "The Miraculous Journey of Edward Tulane",
                    Author = "Kate DiCamillo",
                    Picture = "TheMiraculousJourneyOfEdwardTulane.jpg",
                    Content = ""
                }
                );
        }
    }
}
