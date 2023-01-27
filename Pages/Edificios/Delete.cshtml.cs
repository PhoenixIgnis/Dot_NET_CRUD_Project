using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace JABIL_Project.Pages.Edificios
{
    public class DeleteModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public DeleteModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Buildings Buildings { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Buildings == null)
            {
                return NotFound();
            }

            var buildings = await _context.Buildings.FirstOrDefaultAsync(m => m.PKBuilding == id);

            if (buildings == null)
            {
                return NotFound();
            }
            else 
            {
                Buildings = buildings;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Buildings == null)
            {
                return NotFound();
            }
            var buildings = await _context.Buildings.FindAsync(id);

            if (buildings != null)
            {
                Buildings = buildings;
                _context.Buildings.Remove(Buildings);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
