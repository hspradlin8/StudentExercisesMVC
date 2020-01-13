using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15, ErrorMessage = "First Name must be less than 15 characters")]
        public string Name {get;set;}
        
    }
}
