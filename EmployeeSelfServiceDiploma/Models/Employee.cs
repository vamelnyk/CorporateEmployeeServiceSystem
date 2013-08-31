using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Логін")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Ім'я працівника")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Прізвище")]
        [MaxLength(50)]
        public string LastName { get; set; }

        //Employee full name
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата народження")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Електронна пошта")]
        public string Email { get; set; }

        [Display(Name = "Skype")]
        public string Im { get; set; }

        //Employee Profile Photo
        public string Photo { get; set; }

        //Employee Resume File
        public byte[] CV { get; set; }

        public int MaritalStatusID { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }

        public int PositionID { get; set; }
        public virtual Position Position { get; set; }

        #region Collections
        public virtual ICollection<Salary> Salaries { get; set; }

        //Relationship to templated applications
        [Display(Name = "Стандартні заяви")]
        public virtual ICollection<UserTemplatedApplication> UserTemplatedApplications { get; set; }

        //Relationship to tasks
        [Display(Name = "Завдання працівника")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //Relationship to projects
        [Display(Name = "Проекти працівника")]
        public virtual ICollection<Parcipiant> Parcipiants { get; set; }

        //Employee messages
        public virtual ICollection<Message> inboxMessages { get; set; }
        public virtual ICollection<Message> outboxMessages { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        #endregion
    }
}