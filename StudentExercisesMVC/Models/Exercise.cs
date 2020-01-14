using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Display(Name = "Exercise Name")]
        public string Name { get; set; }
        [Display(Name = "Exercise Language")]
        public string Language { get; set; }
       
    }
}
