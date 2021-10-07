using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using RazorPhamVanTruong.Data;

namespace RazorPhamVanTruong.Pages_Lectures
{
    public class CreateModel : PageModel
    {
        private readonly RazorPhamVanTruong.Data.RazorPagesMovieContext _context;

        public CreateModel(RazorPhamVanTruong.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lecture Lecture { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lecture.Add(Lecture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
