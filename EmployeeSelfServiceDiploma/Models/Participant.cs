using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class Parcipiant
    {
        public int ParcipiantID { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
    }
}