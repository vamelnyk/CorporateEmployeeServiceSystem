using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Gender
    {
        public int GenderId { get; set; }

        [Display(Name = "Стать")]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
