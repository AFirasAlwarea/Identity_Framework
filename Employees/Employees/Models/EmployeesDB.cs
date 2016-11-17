using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employees.Models
{
    public class EmployeesDB : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Cities> Cities { get; set; }
    }
}