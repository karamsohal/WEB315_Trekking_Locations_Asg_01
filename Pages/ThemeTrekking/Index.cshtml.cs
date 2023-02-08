using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            ThemeTrekking = await _context.ThemeTrekking.ToListAsync();
        }
    }
}
