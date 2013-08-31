using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Введіть назву відділу")]
        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}