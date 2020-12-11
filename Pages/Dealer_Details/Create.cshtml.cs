using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Dealer_Details
{
    public class CreateModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagementDatabase _context;

        public CreateModel(PropertyManagement.Data.PropertyManagementDatabase context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dealer_Detail Dealer_Detail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dealer_Detail.Add(Dealer_Detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
