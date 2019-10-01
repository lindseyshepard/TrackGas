using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace MilesPerGallon.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MilesPerGallonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MilesPerGallonContext>>()))
            {
                // Look for any movies.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        FirstName = "Lindsey",
                        CarModel = "Subaru",
                        MilesDriven = 100,
                        FillupDate = DateTime.Parse("1989-2-12"),

                    }


                );
                context.SaveChanges();
            }
        }
    }
}