using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Position
    {
        public int PositionId { get; set; }

        [Required(ErrorMessage = "Введіть назву посади")]
        public string Name { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}