using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Training
    {
        public int TrainingId { get; set; }

        [Required(ErrorMessage = "Введіть назву тренінгу")]
        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Event date")]
        public DateTime? Date { get; set; }
    }
}