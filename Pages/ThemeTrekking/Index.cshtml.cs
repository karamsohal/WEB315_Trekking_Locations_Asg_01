using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB315_Trekking_Locations_Asg_01.Models;

namespace WEB315_Trekking_Locations_Asg_01.Pages_ThemeTrekking
{
    public class IndexModel : PageModel
    {
        private readonly ThemeTrekkingContext _context;

        public IndexModel(ThemeTrekkingContext context)
        {
            _context = context;
        }

        public IList<ThemeTrekking> ThemeTrekking { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public SelectList Trekking { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TrekkingLocations { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> LocationNameQuery = from l in _context.ThemeTrekking
                                    orderby l.LocationName
                                    select l.LocationName;

            var TrekSpot = from t in _context.ThemeTrekking
                        select t;

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                TrekSpot = TrekSpot.Where(s => s.LocationName.Contains(SearchTerm) || s.Popularity.Contains(SearchTerm) || s.VisitorName.Contains(SearchTerm));

            }

            if (!string.IsNullOrEmpty(TrekkingLocations))
            {
                TrekSpot = TrekSpot.Where(x => x.LocationName == TrekkingLocations);
            }
            Trekking = new SelectList(await LocationNameQuery.Distinct().ToListAsync());
            ThemeTrekking = await TrekSpot.ToListAsync();
        }
    }
}
