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
    public class IndexModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public IndexModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public IList<Dealer_Detail> Dealer_Detail { get;set; }

        public async Task OnGetAsync()
        {
            Dealer_Detail = await _context.Dealer_Detail.ToListAsync();
        }
    }
}
