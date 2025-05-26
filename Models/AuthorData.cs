using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStore.Data;
using System;
using System.Linq;

namespace BookStore.Models;

public static class AuthorData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookStoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BookStoreContext>>()))
        {
            // Look for any movies.
            if (context.Author.Any())
            {
                return;   // DB has been seeded
            }
            context.Author.AddRange(
                new Author
                {
                    Name = "Мариам",
                    Surname = "Петросян",
                    QuantityOfBooks = 2
                },
                new Author
                {
                    Name = "Маша",
                    Surname = "Трауб",
                    QuantityOfBooks = 80
                },
                new Author
                {
                    Name = "Дэниел",
                    Surname = "Киз",
                    QuantityOfBooks = 7
                },
                new Author
                {
                    Name = "Нил",
                    Surname = "Гейман",
                    QuantityOfBooks = 500
                },
                new Author
                {
                    Name = "Терри",
                    Surname = "Пратчетт",
                    QuantityOfBooks = 75
                }
            );
            context.SaveChanges();
        }
    }
}