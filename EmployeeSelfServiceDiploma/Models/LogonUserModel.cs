using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class LogonUserModel
    {
        [Required(ErrorMessage = "Обязательное поле!")]
        [Display(Name = "Логин")]
        [StringLength(256, ErrorMessage = "Длина логина должна быть более {2} и менее {1} символов!", MinimumLength = 5)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Обязательное поле!")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}