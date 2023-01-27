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
    public class DetailsModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public DetailsModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

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
    }
}
