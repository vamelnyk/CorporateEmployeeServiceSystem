using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Введіть назву проекту")]
        public string Name { get; set; }

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата початку")]
        public DateTime? StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата закінчення")]
        public DateTime? EndDate { get; set; }

        public int ProjectStatusID { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }

        public virtual ICollection<Parcipiant> Parcipiants { get; set; }
    }
}