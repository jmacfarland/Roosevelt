using System;
using System.ComponentModel.DataAnnotations;

namespace Roosevelt.Api.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        public string age { get; set; }
        public string parent_1 { get; set; }
        public string parent_2 { get; set; }
        public string phone { get; set; }
        public string attendance { get; set; }
        public string days_membership { get; set; }
        public string teacher_name { get; set; }
        public string t_school { get; set; }
        public string t_grade { get; set; }
    }
}