using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CrudPracticeMVC.Models
{
    [Table("tbl_Employee")]
    public class Employee
    {
        
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmpPassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }


}