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
    public class EditModel : PageModel
    {
        private readonly ThemeTrekkingContext _context;

        public EditModel(ThemeTrekkingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ThemeTrekking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeTrekkingExists(ThemeTrekking.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ThemeTrekkingExists(int id)
        {
            return _context.ThemeTrekking.Any(e => e.ID == id);
        }
    }
}
