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
    [Migration("20211007113737_Create_Table_Lectures")]
    partial class Create_Table_Lectures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("RazorPagesMovie.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mnv")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Lecture", b =>
                {
                    b.Property<int>("LectureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Maths")
                        .HasColumnType("TEXT");

                    b.Property<int>("numbers")
                        .HasColumnType("INTEGER");

                    b.HasKey("LectureID");

                    b.ToTable("Lecture");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("RazorPhamVanTruong.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
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
