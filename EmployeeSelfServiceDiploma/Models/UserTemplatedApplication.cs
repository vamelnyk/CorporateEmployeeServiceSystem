using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Models
{
    public class UserTemplatedApplication
    {
        public int UserTemplatedApplicationID { get; set; }
        public int TemplatedApplicationID { get; set; }
        public int EmployeeID { get; set; }
        public virtual TemplatedApplication TemplatedApplication { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
