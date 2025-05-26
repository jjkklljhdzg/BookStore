using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStore.Data;
using System;
using System.Linq;

namespace BookStore.Models;

public static class OrderData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookStoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BookStoreContext>>()))
        {
            // Look for any movies.
            if (context.Order.Any())
            {
                return;   // DB has been seeded
            }
            context.Order.AddRange(
                new Order
                {
                    OrderDate = DateTime.Parse("2025-04-29"),
                    AmountOfBooks = 2,
                    Price = 900
                },
                new Order
                {
                    OrderDate = DateTime.Parse("2025-05-01"),
                    AmountOfBooks = 3,
                    Price = 1050
                },
                new Order
                {
                    OrderDate = DateTime.Parse("2025-05-15"),
                    AmountOfBooks = 4,
                    Price = 1400
                }
            );
            context.SaveChanges();
        }
    }
}