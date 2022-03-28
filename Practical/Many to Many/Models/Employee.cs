using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Many_to_many.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public String MobileNo { get; set; }
        public int Salary { get; set; }
      public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}