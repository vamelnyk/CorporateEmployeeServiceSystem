using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }

        [Display(Name = "Заробітна плата")]
        public string Value { get; set; }

        [Display(Name = "Премія")]
        public string Premium { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата нарахування")]
        public DateTime? Date { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}