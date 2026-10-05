using Library_Mangment_Case.Model;
using Microsoft.EntityFrameworkCore;

namespace Library_Mangment_Case.Database_Context
{
    public class App_Database_Context : DbContext
    {
        public App_Database_Context(DbContextOptions<App_Database_Context> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }


        /*
         Relation By Fluent API 
        •	Category ↔ Book → One-to-Many
        •	Member ↔ Borrowing → One-to-Many
        •	Book ↔ Borrowing → One-to-Many
         */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Books)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Member>()
                .HasMany(m => m.Borrowings)
                .WithOne(b => b.Member)
                .HasForeignKey(b => b.MemberId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Borrowings)
                .WithOne(br => br.Book)
                .HasForeignKey(br => br.BookId);


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming", Description = "Programming and software development books" },
                new Category { Id = 2, Name = "Database", Description = "Database and data management books" });

            modelBuilder.Entity<Book>().HasData(
                new Book { Author = "John Smith", CategoryId = 1, Id = 1, ISBN = "ISBN001", IsAvailable = true, Price = 450, Title = "C++ Basics" },
                new Book { Author = "Sarah Ali", CategoryId = 2, Id = 2, ISBN = "ISBN002", IsAvailable = false, Price = 500, Title = "SQL Fundamentals" }
                );

            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, Name = "Ahmed Hassan", Email= "ahmed@example.com",PhoneNumber= "01012345678" },
                new Member { Id = 2, Name = "Sara Mohamed", Email= "sara@example.com", PhoneNumber= "01198765432" }
                );
            modelBuilder.Entity<Borrowing>().HasData(
                new Borrowing { Id = 1, BorrowedDate = new DateTime(2026, 9, 20), ReturnedDate = new DateTime(2026, 9, 25), MemberId = 1, BookId = 1 },
                new Borrowing { Id = 2, BorrowedDate = new DateTime(2026, 9, 22), ReturnedDate = null, MemberId = 2, BookId = 2 }
                );

        }


    }
}
