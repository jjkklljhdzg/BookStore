using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStore.Data;
using System;
using System.Linq;

namespace BookStore.Models;

public static class BookData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookStoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BookStoreContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "Дом, в котором",
                    ReleaseDate = DateTime.Parse("2009-11-01"),
                    Genre = "Фэнтези",
                    Price = 500,
                    OrderID = 2
                },
                new Book
                {
                    Title = "Благие знамения",
                    ReleaseDate = DateTime.Parse("1990-5-10"),
                    Genre = "Фэнтези",
                    Price = 400,
                    OrderID = 3
                },
                new Book
                {
                    Title = "Цветы для Элджернона",
                    ReleaseDate = DateTime.Parse("1959-4-01"),
                    Genre = "Научная фантастика",
                    Price = 350,
                    OrderID = 4
                },
                new Book
                {
                    Title = "Лишние Дети",
                    ReleaseDate = DateTime.Parse("2019-1-01"),
                    Genre = "Сентиментальная проза",
                    Price = 300,
                    OrderID = 5
                }
            );
            context.SaveChanges();
        }
    }
}