using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPhamVanTruong.Models;

namespace RazorPhamVanTruong.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } 
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {       
             var Movies =   from m in _context.Movie
                            orderby m.Genre
                            select m;
            if (!string.IsNullOrEmpty(SearchString))
                {
                    Movies = Movies.Where(s => s.Title.Contains(SearchString));
                }
            if (!string.IsNullOrEmpty(MovieGenre))
                {
                    Movies = Movies.Where(x => x.Genre == MovieGenre);
                }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await _context.Movie.ToListAsync();
            
        }
    }
}
