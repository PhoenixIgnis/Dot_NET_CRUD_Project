using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace Dot_NET_CRUD_Project.Pages.Piezas
{
    public class DetailsModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public DetailsModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

      public PartNumbers PartNumbers { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PartNumbers == null)
            {
                return NotFound();
            }

            var partnumbers = await _context.PartNumbers.FirstOrDefaultAsync(m => m.PKPartNumber == id);
            if (partnumbers == null)
            {
                return NotFound();
            }
            else 
            {
                PartNumbers = partnumbers;
            }
            return Page();
        }
    }
}
