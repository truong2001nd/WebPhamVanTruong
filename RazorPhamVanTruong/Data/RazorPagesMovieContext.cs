using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPhamVanTruong.Models;
using RazorPagesMovie.Models;

namespace RazorPhamVanTruong.Data
{
public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {

        }

        public DbSet<RazorPhamVanTruong.Models.Movie> Movie { get; set; }
        public DbSet<RazorPhamVanTruong.Models.SinhVien> SinhViens{get;set;}
        public DbSet<RazorPagesMovie.Models.Person> Person { get; set; }
        public DbSet<RazorPagesMovie.Models.Employee> Employee { get; set; }
        public DbSet<RazorPagesMovie.Models.Lecture> Lecture { get; set; }
        
    }
}
  
