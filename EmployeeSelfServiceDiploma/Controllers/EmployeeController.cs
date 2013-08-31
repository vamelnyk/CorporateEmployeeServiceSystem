using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeSelfServiceDiploma.Models;
using System.Web.Caching;
using PagedList;

namespace EmployeeSelfServiceDiploma.Controllers
{
    public class EmployeeController : Controller
    {
        private EnterpriseContext db = new EnterpriseContext();

        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Employee/Logon
        public ActionResult Logon()
        {
            return View();
        }

        //
        // POST: /Employee/Logon
        [HttpPost]
        public ActionResult Logon(Employee user)
        {
            var employee = db.Employees.FirstOrDefault(s => s.UserName.Contains(user.UserName)
                && s.Password.Contains(user.Password));

            if (employee != null)
            {
                Session.Add("user", employee.EmployeeId);
                Session.Add("name", employee.FullName);
                return RedirectToAction("Profile");
            }
            else
            {
                ViewBag.Error = "Ім'я користувача або пароль вказані невірно!";
                return View();
            }
            
        }

        //
        // GET: /Employee/Logon
        public ActionResult Logout()
        {
            Session.Remove("user");

            return RedirectToAction("Logon");
        }

        // GET: /Employee/Profile
        public ActionResult Profile()
        {
            int id = (int)Session["user"];
            var employee = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int id=0)
        {
            var employee = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        //List of employees (watching). Search them
        public ViewResult Colleges(string currentFilter, string searchString, int? page)
        {
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                page = 1;
            }
            ViewBag.CurrentFilter = searchString;

            var employees = from s in db.Employees
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper())
                                       || s.FirstName.ToUpper().Contains(searchString.ToUpper())
                                       || (s.FirstName + " " + s.LastName).ToUpper().Contains(searchString.ToUpper())
                                       || (s.LastName + " " + s.FirstName).ToUpper().Contains(searchString.ToUpper()));
            }

            employees = employees.OrderBy(s => s.LastName);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(employees.ToPagedList(pageNumber, pageSize));
        }

        // Employee tasks
        public ActionResult Tasks(int id = 0)
        {
            id = (int)Session["user"];
            var employee = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaritalStatusID = new SelectList(db.MaritalStatus, "MaritalStatusId", "Status", employee.MaritalStatusID);
            ViewBag.PositionID = new SelectList(db.Positions, "PositionId", "Name", employee.PositionID);
            return View(employee);
        }
    }
}