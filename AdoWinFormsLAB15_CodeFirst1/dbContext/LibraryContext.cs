using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AdoWinFormsLAB15_CodeFirst1.dbModel;
namespace AdoWinFormsLAB15_CodeFirst1.dbContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("dbLibrary")
        {
            Database.SetInitializer(new myInitializer());
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

    }
    public class myInitializer : CreateDatabaseIfNotExists<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            Author author1 = new Author { Name = "Author1" };
            Author author2 = new Author { Name = "Author2" };
            Author author3 = new Author { Name = "Author3" };
            Author author4 = new Author { Name = "Author4" };
            Author author5 = new Author { Name = "Author5" };
            context.Authors.AddRange(new[] { author1, author2, author3, author4, author5 });
            context.SaveChanges();

            User user1 = new User { UserName = "User1", IsDebtor = true };
            User user2 = new User { UserName = "User2", IsDebtor = true };
            User user3 = new User { UserName = "User3", IsDebtor = true };
            User user4 = new User { UserName = "User4", IsDebtor = false };
            User user5 = new User { UserName = "User5", IsDebtor = false };
            context.Users.AddRange(new[] { user1, user2, user3, user4, user5 });
            context.SaveChanges();

            Book book1 = new Book { Title = "Book1", Price = 2000, Pages = 1000, UserId = 1};
            Book book2 = new Book { Title = "Book2", Price = 1500, Pages = 700, UserId = 1};
            Book book3 = new Book { Title = "Book3", Price = 1200, Pages = 600, UserId = 2};
            Book book4 = new Book { Title = "Book4", Price = 1200, Pages = 600, UserId = 3};
            Book book5 = new Book { Title = "Book5", Price = 1200, Pages = 600 };
            context.Books.AddRange(new[] { book1, book2, book3, book4, book5 });
            context.SaveChanges();


            author1.Books.Add(book1);
            author1.Books.Add(book2);
            author2.Books.Add(book1);
            author2.Books.Add(book3);
            author3.Books.Add(book3);
            author4.Books.Add(book4);
            author5.Books.Add(book5);
            base.Seed(context);
        }
    }

}
