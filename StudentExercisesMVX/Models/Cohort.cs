using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVX.Models
{
    public class Cohort
    {
        [Display(Name = "Cohort Id")]
        public int? Id { get; set; }

        [Display(Name = "Cohort")]
        public string Name { get; set; }
    }
}
