using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeSelfServiceDiploma.Models;
using EmployeeSelfServiceDiploma.Models.PDF;

namespace EmployeeSelfServiceDiploma.Controllers
{
    public class TemplatedApplicationController : PdfViewController
    {
        private EnterpriseContext db = new EnterpriseContext();

        //
        // GET: /TemplatedApplication/

        public ActionResult Index()
        {
            return View(db.TemplatedApplications.ToList());
        }

        //
        // GET: /TemplatedApplication/Details/5

        public ActionResult Details(int id = 0)
        {
            TemplatedApplication templatedapplication = db.TemplatedApplications.Find(id);
            if (templatedapplication == null)
            {
                return HttpNotFound();
            }
            return View(templatedapplication);
        }

        //
        // GET: /TemplatedApplication/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TemplatedApplication templatedapplication = db.TemplatedApplications.Find(id);
            if (templatedapplication == null)
            {
                return HttpNotFound();
            }
            return View(templatedapplication);
        }

        //
        // POST: /TemplatedApplication/Edit/5

        [HttpPost]
        public ActionResult Edit(TemplatedApplication templatedapplication)
        {
            UserTemplatedApplication userapp = db.UserTemplatedApplications.Find(templatedapplication.TemplatedApplicationId);
            userapp.EmployeeID = (int)Session["user"];
            templatedapplication.Date = DateTime.Now;
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(templatedapplication).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Details/" + templatedapplication.TemplatedApplicationId, "TemplatedApplication");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(templatedapplication);
        }

        public ActionResult File(int id = 0)
        {
            TemplatedApplication app = db.TemplatedApplications.Find(id);
            // Generate PDF file
            return this.ViewPdf(" ", "TemplatedPdfApplication", app);
            //return new RazorPDF.PdfResult(app, "TemplatedPdfApplication");
        }
    }
}