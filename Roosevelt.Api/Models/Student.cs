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
        public string school { get; set; }
        public string grade_year { get; set; }
        public string y_summer_read { get; set; }
        public string y_star_grade_equivalent { get; set; }
        public string y_star_percentile { get; set; }
        public string y_star_irl { get; set; }
    }
}