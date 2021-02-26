using CrudPracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudPracticeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _employeeContext = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            return View(_employeeContext.GetEmployees());
        }
    }
}