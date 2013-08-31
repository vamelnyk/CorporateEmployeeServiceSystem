using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class ProjectStatus
    {
        public int ProjectStatusId { get; set; }

        [Required(ErrorMessage = "Введіть статус")]
        public string Status { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}