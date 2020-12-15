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
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public EditModel(PropertyManagement.Data.PropertyManagement_Database context)
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

            Property_Oction = await _context.Property_Oction
                .Include(p => p.Customer_Detail)
                .Include(p => p.Dealer_Detail)
                .Include(p => p.Property_Detail).FirstOrDefaultAsync(m => m.Id == id);

            if (Property_Oction == null)
            {
                return NotFound();
            }
           ViewData["Customer_DetailId"] = new SelectList(_context.Customer_Detail, "Id", "Customer_Name");
           ViewData["Dealer_DetailId"] = new SelectList(_context.Dealer_Detail, "Id", "Dealer_Name");
           ViewData["Property_DetailId"] = new SelectList(_context.Property_Detail, "Id", "Area");
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
                if (!Property_OctionExists(Property_Oction.Id))
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
            return _context.Property_Oction.Any(e => e.Id == id);
        }
    }
}
