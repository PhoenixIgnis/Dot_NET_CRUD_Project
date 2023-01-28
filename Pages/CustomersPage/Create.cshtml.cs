using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dot_NET_CRUD_Project.Models;

namespace Dot_NET_CRUD_Project.Pages.CustomersPage
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
        ViewData["FKBuilding"] = new SelectList(_context.Buildings, "PKBuilding", "Building");
            return Page();
        }

        [BindProperty]
        public Customers Customers { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Customers == null || Customers == null)
            {
                return Page();
            }

            _context.Customers.Add(Customers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
