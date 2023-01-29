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
using ClosedXML.Excel;
using System.Text;
using System.Data;
using NuGet.Common;

namespace Dot_NET_CRUD_Project.Pages.PartNumbersPage
{
    public class IndexModel : PageModel
    {
        private readonly Dot_NET_CRUD_Project.Models.DatabaseContext _context;

        public IndexModel(Dot_NET_CRUD_Project.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<PartNumbers> PartNumbers { get;set; }

        public async Task OnGetAsync(string filter)
        {
            PartNumbers = await LoadPartNumbers(filter);
        }

        public async Task<FileResult> OnPostExport(string filter)
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Part Number"),
                                    new DataColumn("Availability"),
                                    new DataColumn("Customer"),
                                    new DataColumn("Building") });

            PartNumbers = await LoadPartNumbers(filter);

            foreach (var partNumber in this.PartNumbers)
            {
                dt.Rows.Add(partNumber.PartNumber, partNumber.Available, partNumber.Customer.Customer, partNumber.Customer.Building.Building);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "PartNumbersData-"+DateTime.UtcNow.ToString("dd/MM/yyyy-h:m:tt") + ".xlsx");
                }
            }
        }

        private async Task<IList<PartNumbers>> LoadPartNumbers(string filter)
        {
            ViewData["filter"] = filter;
            switch (filter)
            {
                case "true":
                    return await _context.PartNumbers.Where(p => p.Available == true).Include(c => c.Customer.Building).ToListAsync();
                case "false":
                    return await _context.PartNumbers.Where(p => p.Available == false).Include(c => c.Customer.Building).ToListAsync();
                default:
                    return await _context.PartNumbers.Include(c => c.Customer.Building).ToListAsync();
            }
        }
    }
}
