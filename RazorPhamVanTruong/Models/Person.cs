using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public int age { get; set; }
    }
}