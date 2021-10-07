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
    public class IndexModel : PageModel
    {
        private readonly RazorPhamVanTruong.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPhamVanTruong.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Lecture> Lecture { get;set; }

        public async Task OnGetAsync()
        {
            Lecture = await _context.Lecture.ToListAsync();
        }
    }
}
