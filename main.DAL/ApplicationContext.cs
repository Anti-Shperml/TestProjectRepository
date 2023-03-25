using main.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(string connectionString)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Entity.Task> Tasks { get; set; }

    }
}
