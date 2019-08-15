using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVX.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }

        public Student Student { get; set; }

        public StudentEditViewModel() { }

        public StudentEditViewModel(Student student, List<Cohort> cohorts)
        {
            Student = student;
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
