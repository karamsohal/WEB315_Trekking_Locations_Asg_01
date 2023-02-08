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
    public class DetailsModel : PageModel
    {
        private readonly ThemeTrekkingContext _context;

        public DetailsModel(ThemeTrekkingContext context)
        {
            _context = context;
        }

        public ThemeTrekking ThemeTrekking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeTrekking = await _context.ThemeTrekking.FirstOrDefaultAsync(m => m.ID == id);

            if (ThemeTrekking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
