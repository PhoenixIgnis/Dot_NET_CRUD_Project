using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace Dot_NET_CRUD_Project.Pages.PartNumbersPage
{
    public class EditModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public EditModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PartNumbers PartNumbers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PartNumbers == null)
            {
                return NotFound();
            }

            var partnumbers =  await _context.PartNumbers.FirstOrDefaultAsync(m => m.PKPartNumber == id);
            if (partnumbers == null)
            {
                return NotFound();
            }
            PartNumbers = partnumbers;
           ViewData["FKCustomer"] = new SelectList(_context.Customers, "PKCustomers", "Customer");
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

            _context.Attach(PartNumbers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartNumbersExists(PartNumbers.PKPartNumber))
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

        private bool PartNumbersExists(int id)
        {
          return (_context.PartNumbers?.Any(e => e.PKPartNumber == id)).GetValueOrDefault();
        }
    }
}
