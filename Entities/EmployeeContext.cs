
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace myApp.Entities
{


    /// <summary>
    /// The entity framework context with a Employees DbSet
    /// </summary>
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
        : base(options)
        {
             this.Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries {get;set;}
    }


    
}