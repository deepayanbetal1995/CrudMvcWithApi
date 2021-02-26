using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudPracticeMVC.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(): base("name=CrudPractice")
        {

        }

        public DbSet<Employee> employees { get; set; }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees.ToList();
        }
    }
}