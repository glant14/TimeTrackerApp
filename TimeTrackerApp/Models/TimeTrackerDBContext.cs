using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Namespace
using System.Data.Entity;

namespace TimeTrackerApp.Models
{
    //2. Inherit from DBContext
    public class TimeTrackerDBContext: DbContext
    {
        //3. GEt the DB Sets from DB tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimeCards { get; set; }
    }
}
