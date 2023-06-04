using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using Animals.Data;
using System;
using System.Linq;

namespace Animals.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnimalsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnimalsContext>>()))
            {
                // Look for any Animals.
                if (context.Animal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Animal.AddRange(
                    new Animal
                    {
                        Name = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Animal
                    {
                        Name = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Animal
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Animal
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}