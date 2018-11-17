using System;
using System.ComponentModel.DataAnnotations;

namespace Roosevelt.Api.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        public int age { get; set; }
        public string parent_1 { get; set; }
        public string parent_2 { get; set; }
        public string phone { get; set; }
        public int attendance { get; set; }
        public int days_membership { get; set; }
    }
}