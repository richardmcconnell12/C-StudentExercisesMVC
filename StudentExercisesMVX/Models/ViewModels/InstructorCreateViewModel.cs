using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVX.Models.ViewModels
{
    public class InstructorCreateViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }

        public Instructor Instructor { get; set; }
    }
}
