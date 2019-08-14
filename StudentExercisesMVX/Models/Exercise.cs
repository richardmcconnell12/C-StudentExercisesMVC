using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVX.Models
{
    public class Exercise
    {
        [Display(Name = "Exercise Id")]
        public int Id { get; set; }

        [Display(Name = "Exercise Name")]
        public string Name { get; set; }

        [Display(Name = "Language")]
        public string Language { get; set; }
    }
}
