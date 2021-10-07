using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPhamVanTruong.Data;

namespace RazorPhamVanTruong.Pages_Employees
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPhamVanTruong.Data.RazorPagesMovieContext _context;

        public DetailsModel(RazorPhamVanTruong.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
