using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Task
    {
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Введіть назву завдання")]
        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        public int TaskStatusID { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}