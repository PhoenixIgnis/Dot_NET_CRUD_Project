using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace Dot_NET_CRUD_Project.Pages.PartNumbersPage
{
    public class IndexModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public IndexModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<PartNumbers> PartNumbers { get;set; } = default!;

        public async Task OnGetAsync(string filter)
        {
            if (_context.PartNumbers != null)
            {
                switch (filter)
                {
                    case "true":
                        PartNumbers = await _context.PartNumbers.Where(x => x.Available == true).Include(p => p.Customer).ToListAsync();
                        break;
                    case "false":
                        PartNumbers = await _context.PartNumbers.Where(x => x.Available == false).Include(p => p.Customer).ToListAsync();
                        break;
                    default:
                        PartNumbers = await _context.PartNumbers.Include(p => p.Customer).ToListAsync();
                        break;
                }
                
            }
        }
    }
}
