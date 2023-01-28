using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;
using Azure;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dot_NET_CRUD_Project.Pages.PartNumbersPage
{
    public class IndexModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;


        [BindProperty(SupportsGet = true)]
        public string filter { get; set; }

        public IndexModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<PartNumbers> PartNumbers { get;set; } = default!;

        public async Task OnGetAsync()
        {
             
            if (_context.PartNumbers != null)
            {
                ViewData["filter"] = filter;

                switch (filter)
                {
                    case "true":
                        PartNumbers = await _context.PartNumbers.Where(p => p.Available == true).Include(c => c.Customer).ThenInclude(b => b.Building).ToListAsync();
                        break;
                    case "false":
                        PartNumbers = await _context.PartNumbers.Where(p => p.Available == false).Include(c => c.Customer).ThenInclude(b => b.Building).ToListAsync();
                        break;
                    default:
                        PartNumbers = await _context.PartNumbers.Include(c => c.Customer).ThenInclude(b => b.Building).ToListAsync();
                        break;
                }
                
            }
        }
    }
}
