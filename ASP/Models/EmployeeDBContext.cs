using ASP.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.Models
{
    public class EmployeeDBContext : DbContext
    {
         public EmployeeDBContext(DbContextOptions<EmployeeDBContext> contextOptions)
                : base(contextOptions)
         {

         }
         public DbSet<Employee> Employees { get; set; }
       
    }
}
