using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }

        [Required]
        [Display(Name = "Назва заяви")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Введіть описання вашої заяви")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата оформлення")]
        public DateTime Date { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}