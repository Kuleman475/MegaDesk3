using Microsoft.EntityFrameworkCore;
using MegaDesk3.Data;


namespace MegaDesk3.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDesk3Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDesk3Context>>()))
            {
                if (context == null || context.Quote == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        FirstName = "Sally",
                        LastName = "Thompson",
                        Width = 37,
                        Depth = 40,
                        Drawers = 2,
                        Materials = 4,
                        OrderDate = DateTime.Parse("02/23/2022"),
                        RushOrderShipping = 5,

                    },

                    new Quote
                    {
                        FirstName = "Harry",
                        LastName = "Potter",
                        Width = 44,
                        Depth = 30,
                        Drawers = 2,
                        Materials = 2,
                        OrderDate = DateTime.Parse("02/22/2022"),
                        RushOrderShipping = 14,
                    },

                    new Quote
                    {
                        FirstName = "Steve",
                        LastName = "Rogers",
                        Width = 50,
                        Depth = 30,
                        Drawers = 0,
                        Materials = 1,
                        OrderDate = DateTime.Parse("07/04/2018"),
                        RushOrderShipping = 14,
                    },

                    new Quote
                    {
                        FirstName = "Tony",
                        LastName = "Stark",
                        Width = 96,
                        Depth = 48,
                        Drawers = 7,
                        Materials = 3,
                        OrderDate = DateTime.Parse("02/24/2022"),
                        RushOrderShipping = 3,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
