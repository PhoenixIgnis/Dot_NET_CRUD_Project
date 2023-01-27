using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dot_NET_CRUD_Project.Models;

namespace JABIL_Project.Pages.Piezas
{
    public class CreateModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public CreateModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FKCustomer"] = new SelectList(_context.Customers, "PKCustomers", "Customer");
            return Page();
        }

        [BindProperty]
        public PartNumbers PartNumbers { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.PartNumbers == null || PartNumbers == null)
            {
                return Page();
            }

            _context.PartNumbers.Add(PartNumbers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
