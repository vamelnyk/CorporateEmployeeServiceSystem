using EmployeeSelfServiceDiploma.Models;
using EmployeeSelfServiceDiploma.Models.PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Controllers
{
    public class SalaryController : PdfViewController
    {
        private EnterpriseContext db = new EnterpriseContext();
        //
        // GET: /Salary/

        public ActionResult Index()
        {
            return View(db.Employees.Find(Session["user"]).Salaries.ToList());
        }

        public ActionResult SalaryToPDF()
        {
            // Generate PDF file
            return this.ViewPdf(" ", "SalaryToPDF", db.Employees.Find(Session["user"]).Salaries.ToList());
        }
    }
}
