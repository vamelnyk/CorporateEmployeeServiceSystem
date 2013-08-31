using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Models
{
    public class TemplatedApplication
    {
        public int TemplatedApplicationId { get; set; }

        [Required]
        [Display(Name = "Назва заявки")]
        public string Title { get; set; }

        [Display(Name = "Введіть описання")]
        public string templatedField1 { get; set; }

        [Display(Name = "Введіть описання")]
        public string templatedField2 { get; set; }

        [DataType(DataType.MultilineText)]
        public string templatedMultiField3 { get; set; }

        [DataType(DataType.MultilineText)]
        public string templatedMultiField4 { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата оформлення заявки")]
        public DateTime Date { get; set; }

        public virtual ICollection<UserTemplatedApplication> UserTemplatedApplications { get; set; }

    }
}
