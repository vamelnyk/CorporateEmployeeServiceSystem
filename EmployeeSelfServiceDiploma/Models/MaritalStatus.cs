using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class MaritalStatus
    {
        public int MaritalStatusId { get; set; }

        [Display(Name = "Сімейний статус")]
        public string Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}