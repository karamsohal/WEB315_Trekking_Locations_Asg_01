using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB315_Trekking_Locations_Asg_01.Models;

namespace WEB315_Trekking_Locations_Asg_01.Pages_ThemeTrekking
{
    public class CreateModel : PageModel
    {
        private readonly ThemeTrekkingContext _context;

        public CreateModel(ThemeTrekkingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ThemeTrekking ThemeTrekking { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ThemeTrekking.Add(ThemeTrekking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
