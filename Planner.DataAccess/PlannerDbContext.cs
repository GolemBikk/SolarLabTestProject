using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Planner.DataAccess
{
    public class PlannerDbContext : DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; }

        public PlannerDbContext() : base("PlannerDB")
        {
        }
    }
}
