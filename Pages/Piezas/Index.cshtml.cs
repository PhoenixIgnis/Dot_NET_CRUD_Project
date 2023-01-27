﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dot_NET_CRUD_Project.Models;

namespace JABIL_Project.Pages.Piezas
{
    public class IndexModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public IndexModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<PartNumbers> PartNumbers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PartNumbers != null)
            {
                PartNumbers = await _context.PartNumbers
                .Include(p => p.Customer).ToListAsync();
            }
        }
    }
}
