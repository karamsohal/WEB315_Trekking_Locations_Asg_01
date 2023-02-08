using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB315_Trekking_Locations_Asg_01.Models;

    public class ThemeTrekkingContext : DbContext
    {
        public ThemeTrekkingContext (DbContextOptions<ThemeTrekkingContext> options)
            : base(options)
        {
        }

        public DbSet<WEB315_Trekking_Locations_Asg_01.Models.ThemeTrekking> ThemeTrekking { get; set; }
    }
