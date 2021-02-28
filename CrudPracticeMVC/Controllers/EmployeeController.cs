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
            return View();
        }

        public ActionResult afterLogin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee emp)
        {
            using (_employeeContext)
            {
                var useDetails = _employeeContext.employees.Where
                    (x=>x.EmployeeName==emp.EmployeeName && x.EmpPassword==emp.EmpPassword)
                    .FirstOrDefault();
                if(useDetails == null)
                {
                    emp.LoginErrorMessage = "Invadid id pass";
                    return View("Login", emp);
                }
                else
                {
                    Session["EmployeeName"] = useDetails.EmployeeName;
                    Session["EmployeeId"] = useDetails.EmployeeId;
                    return RedirectToAction("Index","Employee");
                }
            }
        }
    }
}