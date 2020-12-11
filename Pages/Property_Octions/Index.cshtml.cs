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
    public class IndexModel : PageModel
    {
        private readonly PropertyManagement.Data.PropertyManagementDatabase _context;

        public IndexModel(PropertyManagement.Data.PropertyManagementDatabase context)
        {
            _context = context;
        }

        public IList<Property_Oction> Property_Oction { get;set; }

        public async Task OnGetAsync()
        {
            Property_Oction = await _context.Property_Oction.ToListAsync();
        }
    }
}
