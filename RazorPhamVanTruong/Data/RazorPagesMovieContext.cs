using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPhamVanTruong.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {

        }

        public DbSet<RazorPhamVanTruong.Models.Movie> Movie { get; set; }
        public DbSet<RazorPhamVanTruong.Models.SinhVien> SinhViens{get;set;}
    }
