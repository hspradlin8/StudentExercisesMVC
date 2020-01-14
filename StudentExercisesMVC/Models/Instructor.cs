using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15, ErrorMessage = "First Name must be less than 15 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        public int CohortId { get; set; }
        public string Specialty { get; set; }
        [Display(Name = "Cohort")]
        public Cohort Cohort  { get; set; }
    }
}
