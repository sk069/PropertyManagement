using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertyManagement.Data;
using PropertyManagement.Models;

namespace PropertyManagement.Pages.Property_Details
{
    public class IndexModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagement_Database _context;

        public IndexModel(PropertyManagement.Data.PropertyManagement_Database context)
        {
            _context = context;
        }

        public IList<Property_Detail> Property_Detail { get;set; }

        public async Task OnGetAsync()
        {
            Property_Detail = await _context.Property_Detail.ToListAsync();
        }
    }
}
