using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Property_Octions
{
    public class DetailsModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public DetailsModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public Property_Oction Property_Oction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property_Oction = await _context.Property_Oction
                .Include(p => p.Customer_Detail)
                .Include(p => p.Dealer_Detail)
                .Include(p => p.Property_Detail).FirstOrDefaultAsync(m => m.Id == id);

            if (Property_Oction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
