using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVX.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        public Instructor Instructor { get; set; }

        public List<SelectListItem> Cohorts { get; set; }

        public InstructorEditViewModel() { }

        public InstructorEditViewModel(Instructor instructor, List<Cohort> cohorts)
        {
            Instructor = instructor;
            var selectItems = cohorts
                .Select(cohort => new SelectListItem
                {
                    Text = cohort.Name,
                    Value = cohort.Id.ToString()
                })
                .ToList();

            selectItems.Insert(0, new SelectListItem
            {
                Text = "Choose Cohort...",
                Value = "0"
            });

            Cohorts = selectItems;
        }
    }
}
