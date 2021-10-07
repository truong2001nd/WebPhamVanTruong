using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPhamVanTruong.Data;

namespace RazorPhamVanTruong.Pages_Lectures
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPhamVanTruong.Data.RazorPagesMovieContext _context;

        public DeleteModel(RazorPhamVanTruong.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lecture Lecture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecture = await _context.Lecture.FirstOrDefaultAsync(m => m.LectureID == id);

            if (Lecture == null)
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

            Lecture = await _context.Lecture.FindAsync(id);

            if (Lecture != null)
            {
                _context.Lecture.Remove(Lecture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
