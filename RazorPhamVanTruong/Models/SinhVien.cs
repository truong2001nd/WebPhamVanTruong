using System;
using System.ComponentModel.DataAnnotations;



namespace RazorPhamVanTruong.Models
{
    public class SinhVien
    {
        [Key]
        public int SID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}