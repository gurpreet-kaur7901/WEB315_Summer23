using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Animal.Models
{
    public static class SeedData_Animal
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnimalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnimalContext>>()))
            {
                // Look for any Infos.
                if (context.Info.Any())
                {
                    return;   // DB has been seeded
                }

                context.Info.AddRange(
                    new Info
                    {
                        Name = "Dog",
                        Color = "Black",
                        Breed = "German Shepherd",
                        Gender="M",
                        Age=DateTime.Parse("2011-3-12"),
                        Price = 170.0M,
                        Rating="A1"
                    },

                    new Info
                    {
                        Name = "Cat",
                        Color = "White",
                        Breed = "Scottish Fold",
                        Gender="F",
                        Age=DateTime.Parse("2013-3-04"),
                        Price = 100.0M,
                        Rating="B1"
                    },

                    new Info
                    {
                        Name = "Lion",
                        Color = "Golden",
                        Breed = "Asiatic",
                        Gender="M",
                        Age=DateTime.Parse("2016-5-10"),
                        Price = 150.0M,
                        Rating="C2"
                    },

                    new Info
                    {
                        Name = "Elephant",
                        Color = "Grey",
                        Breed = "Savanna Elephant",
                        Gender="F",
                        Age=DateTime.Parse("2019-6-21"),
                        Price = 200.0M,
                        Rating="A5"
                    },
                    new Info
                    {
                        Name = "Zebra",
                        Color = "Black And White",
                        Breed = "Mountain Zebra",
                        Gender="M",
                        Age=DateTime.Parse("2009-4-21"),
                        Price = 210.0M,
                        Rating="B2"
                    }

                   
                );
                context.SaveChanges();
            }
        }
    }
}