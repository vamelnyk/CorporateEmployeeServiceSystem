using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class TaskStatus
    {
        public int TaskStatusId { get; set; }

        [Required(ErrorMessage = "Введіть статус")]
        public string Status { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}