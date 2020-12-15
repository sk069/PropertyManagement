using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Dealer_Details
{
    public class DetailsModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public DetailsModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public Dealer_Detail Dealer_Detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dealer_Detail = await _context.Dealer_Detail.FirstOrDefaultAsync(m => m.Id == id);

            if (Dealer_Detail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
