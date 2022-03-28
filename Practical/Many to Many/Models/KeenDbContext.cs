using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Many_to_many.Models
{
    public class KeenDbContext:DbContext
    {
public DbSet<Employee>Employee { get; set;}
        public DbSet<Project> Project { get; set; }
        public DbSet<EmployeeProject>EmployeeProject { get; set; }

    }
}