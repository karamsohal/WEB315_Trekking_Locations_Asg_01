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
                        Country = "India",
                        Height = 7345,
                        Popularity = "Balaghat is a city and a municipality in Balaghat district, in the state of Madhya Pradesh, India. It is the administrative headquarters of Balaghat District. Wainganga River flows beside the town.",
                        VisitorName = "Karamjit Sohal"
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Malsej Ghat",
                        PlanningToVisit = DateTime.Parse("2023-3-22"),
                        Place = "Malsej",
                        State = "Maharashtra",
                        Country = "India",
                        Height = 8973,
                        Popularity = "The most famous tourist attraction of Malshej Ghat is the 6th-century Harischandragad Fort, located over 1400 kms above sea level. It is also frequented by devout worshippers of Lord Vishnu who come to pay their homage at the temple located here.",
                        VisitorName = "Lakshya Rajput"
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Karjat Trek",
                        PlanningToVisit = DateTime.Parse("2023-7-16"),
                        Place = "Karjat",
                        State = "Maharashtra",
                        Country = "India",
                        Height = 9872,
                        Popularity = "Karjat is a little hill station near Mumbai. The town is famous for its incredibly Ulhas Valley, breathtaking views, caves and the sacred Kondeshwar temple.",
                        VisitorName = "Harshil Mistry"
                    },

                    new ThemeTrekking
                    {
                        LocationName = "Hill Top Climbing",
                        PlanningToVisit = DateTime.Parse("2023-8-19"),
                        Place = "Indoor",
                        State = "Madhya Pradesh",
                        Country = "India",
                        Height = 10836,
                        Popularity = "Into the Northern Indian Mountains, the Hill Top Climbing is the largest mountain climbing. This weekend, more than 270 climbers are in Hill Top, to take part in the 2023 Indian Lead and Speed National Championships.",
                        VisitorName = "Haider Ali"
                    },


                    new ThemeTrekking
                    {
                        LocationName = "Katmandu",
                        PlanningToVisit = DateTime.Parse("2023-9-05"),
                        Place = "Nepal",
                        State = "Katmandu",
                        Country = "Nepal",
                        Height = 14922,
                        Popularity = "It is ironic that despite Nepal being home to eight of the 14 mountains above 8,000 metres and more than 414 other peaks, an in-depth study of the health of mountaineers, causes of death and training still has not been done.",
                        VisitorName = "Sameep Pradeep"
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}