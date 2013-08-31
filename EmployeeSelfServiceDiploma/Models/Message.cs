using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        public string Theme { get; set; }

        [Required(ErrorMessage = "Введіть текст повідомлення")]
        public string Content { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime SendingDate { get; set; }

    }
}