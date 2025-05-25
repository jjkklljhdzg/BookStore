using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BookStore.Models.Author> Author { get; set; } = default!;
        public DbSet<BookStore.Models.Book> Book { get; set; } = default!;
        public DbSet<BookStore.Models.Order> Order { get; set; } = default!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().HasMany(b => b.Authors)
        //        .WithMany(b => b.Books)
        //        .Map(t =>
        //        {
        //            t.MapLeftKey("BookID");
        //            t.MapRightKey("AuthorID");
        //            t.ToTable("BookAuthor");
        //            });
        //}
    }
}
