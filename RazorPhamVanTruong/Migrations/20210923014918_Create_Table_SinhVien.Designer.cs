// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPhamVanTruong.Data;
namespace RazorPhamVanTruong.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20210923014918_Create_Table_SinhVien")]
    partial class Create_Table_SinhVien
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RazorPhamVanTruong.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("RazorPhamVanTruong.Models.SinhVien", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("SID");

                    b.ToTable("SinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
