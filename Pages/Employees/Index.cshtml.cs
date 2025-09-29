using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_app_oves.Data;

namespace azure_app_oves.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly azure_app_oves.Data.AppDbContext _context;

        public IndexModel(azure_app_oves.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.employees.ToListAsync();
        }
    }
}
