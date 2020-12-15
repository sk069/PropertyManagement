using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Customer_Details
{
    public class IndexModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public IndexModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public IList<Customer_Detail> Customer_Detail { get;set; }

        public async Task OnGetAsync()
        {
            Customer_Detail = await _context.Customer_Detail.ToListAsync();
        }
    }
}
