using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPhamVanTruong.Models;
using RazorPhamVanTruong.Data;
namespace RazorPhamVanTruong.Pages_SinhViens
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public SinhVien SinhVien { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SinhVien = await _context.SinhViens.FirstOrDefaultAsync(m => m.SID == id);

            if (SinhVien == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
