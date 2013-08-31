using EmployeeSelfServiceDiploma.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Controllers
{
    public class TaskController : Controller
    {
        private EnterpriseContext db = new EnterpriseContext();
        
        //
        // GET: /Task/
        public ActionResult Index()
        {
            return View(db.Employees.Find(Session["user"]).Enrollments.ToList());
        }

        //
        // GET: /Task/Confirm/5
        public ActionResult Confirm(int id = 0)
        {
            Task task = db.Tasks.Find(id);
            task.TaskStatusID = 2;
            db.Entry(task).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index", "Task");
        }
    }
}
