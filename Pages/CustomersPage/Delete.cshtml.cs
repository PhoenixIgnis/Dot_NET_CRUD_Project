using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace Dot_NET_CRUD_Project.Pages.CustomersPage
{
    public class DeleteModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public DeleteModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Customers Customers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FirstOrDefaultAsync(m => m.PKCustomers == id);

            if (customers == null)
            {
                return NotFound();
            }
            else 
            {
                Customers = customers;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }
            var customers = await _context.Customers.FindAsync(id);

            if (customers != null)
            {
                Customers = customers;
                _context.Customers.Remove(Customers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
