using Manufacturs.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturs.Data
{

    public class ManufacturContext : DbContext
    {
        public ManufacturContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Integrated Security=true; Database=Manufacturs");
            }
        }
    }

}
