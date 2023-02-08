using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WEB315_Trekking_Locations_Asg_01.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ThemeTrekkingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ThemeTrekkingContext>>()))
            {
                // Look for any movies.
                if (context.ThemeTrekking.Any())
                {
                    return;   // DB has been seeded
                }

                context.ThemeTrekking.AddRange(
                    new ThemeTrekking
                    {
                        LocationName = "Bala Ghat",
                        PlanningToVisit = DateTime.Parse("2023-2-12"),
                        Place = "Virar",
                        State = "Maharashtra",
                        Country = "India"
        
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Malsej Ghat",
                        PlanningToVisit = DateTime.Parse("2023-3-22"),
                        Place = "Malsej",
                        State = "Maharashtra",
                        Country = "India"
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Karjat Trek",
                        PlanningToVisit = DateTime.Parse("2023-7-16"),
                        Place = "Karjat",
                        State = "Maharashtra",
                        Country = "India"
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Hill Top Climbing",
                        PlanningToVisit = DateTime.Parse("2023-8-19"),
                        Place = "Indoor",
                        State = "Madhya Pradesh",
                        Country = "India"
                    },


                    new ThemeTrekking
                    {
                        LocationName = "Katmandu",
                        PlanningToVisit = DateTime.Parse("2023-9-05"),
                        Place = "Nepal",
                        State = "Katmandu",
                        Country = "Nepal"
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}