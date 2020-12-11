using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Property_Octions
{
    public class EditModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagementDatabase _context;

        public EditModel(PropertyManagement.Data.PropertyManagementDatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Property_Oction Property_Oction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property_Oction = await _context.Property_Oction.FirstOrDefaultAsync(m => m.ID == id);

            if (Property_Oction == null)
            {
                return NotFound();
            }
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

            _context.Attach(Property_Oction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Property_OctionExists(Property_Oction.ID))
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

        private bool Property_OctionExists(int id)
        {
            return _context.Property_Oction.Any(e => e.ID == id);
        }
    }
}
