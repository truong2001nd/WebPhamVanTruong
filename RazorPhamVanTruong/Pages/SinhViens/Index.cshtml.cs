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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<SinhVien> SinhVien { get;set; }

        public async Task OnGetAsync()
        {
            SinhVien = await _context.SinhViens.ToListAsync();
        }
    }
}
