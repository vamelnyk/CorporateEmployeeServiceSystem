using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int TaskID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Task Task { get; set; }
        public virtual Employee Employee { get; set; }
    }
}