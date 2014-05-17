using EmployeeSelfServiceDiploma.Models;
using EmployeeSelfServiceDiploma.Models.PDF;
using iTextSharp.text;
using RazorPDF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSelfServiceDiploma.Controllers
{
    public class ApplicationController : PdfViewController
    {
        private EnterpriseContext db = new EnterpriseContext();
        
        //
        // GET: /Application/
        public ActionResult Index()
        {
            return View(db.Employees.Find(Session["user"]));
        }

        // GET: /Employee/Application
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Application
        [HttpPost]
        public ActionResult Create(Application app)
        {
            app.Date = DateTime.Now;

            try
            {
                if (ModelState.IsValid)
                {
                    db.Applications.Add(app);
                    db.Employees.Find(Session["user"]).Applications.Add(app);
                    db.SaveChanges();

                    //File(app.ApplicationId);
                    return RedirectToAction("Details/" + app.ApplicationId, "Application");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(app);
        }

        //
        // GET: /Application/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Application app = db.Applications.Find(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }

        //
        // POST: /Application/Edit/5
        [HttpPost]
        public ActionResult Edit(Application app)
        {
            app.Date = DateTime.Now;

            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(app).State = EntityState.Modified;
                    db.SaveChanges();

                    File(app.ApplicationId);

                    return RedirectToAction("Details/" + app.ApplicationId, "Application");
                }
            }

            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(app);
        }

        //Get PDF file
        public ActionResult File(int id = 0)
        {
            Application app = db.Applications.Find(id);

            // Generate PDF file
            return this.ViewPdf(" ", "PdfApplication", app);
        }

        //
        // GET: /Application/Details/5
        public ActionResult Details(int id = 0)
        {
            Application app = db.Applications.Find(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }

        //
        // GET: /Application/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Applications.Find(id));
        }

        //
        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Application employee = db.Applications.Find(id);
                db.Applications.Remove(employee);
                db.SaveChanges();
            }
            catch
            {
                //Log the error (add a variable name after DataException)
                return RedirectToAction("Delete",
                    new System.Web.Routing.RouteValueDictionary { 
                { "id", id }, 
                { "saveChangesError", true } });
            }
            return RedirectToAction("Index", "Application");
        }
    }
}
