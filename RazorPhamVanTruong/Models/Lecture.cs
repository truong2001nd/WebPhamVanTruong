using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Lecture
    {   [Key]
        public int  LectureID { get; set; }
        public string Maths { get; set; }

       public int numbers { get; set; }
    }
}