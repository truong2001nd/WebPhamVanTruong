using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPhamVanTruong.Models;

namespace RazorPhamVanTruong.Pages_SinhViens
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SinhVien = await _context.SinhViens.FindAsync(id);

            if (SinhVien != null)
            {
                _context.SinhViens.Remove(SinhVien);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
