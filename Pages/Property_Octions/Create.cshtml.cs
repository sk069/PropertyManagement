using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Property_Octions
{
    public class CreateModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public CreateModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Customer_DetailId"] = new SelectList(_context.Customer_Detail, "Id", "Customer_Name");
        ViewData["Dealer_DetailId"] = new SelectList(_context.Dealer_Detail, "Id", "Dealer_Name");
        ViewData["Property_DetailId"] = new SelectList(_context.Property_Detail, "Id", "Area");
            return Page();
        }

        [BindProperty]
        public Property_Oction Property_Oction { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Property_Oction.Add(Property_Oction);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
