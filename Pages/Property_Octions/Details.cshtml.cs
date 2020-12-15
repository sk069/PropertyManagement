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
        private readonly PropertyManagement.Data.PropertyManagementDatabase _context;

        public DetailsModel(PropertyManagement.Data.PropertyManagementDatabase context)
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

            Property_Oction = await _context.Property_Oction.FirstOrDefaultAsync(m => m.Id == id);

            if (Property_Oction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
