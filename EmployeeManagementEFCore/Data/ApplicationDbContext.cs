using EmployeeManagementEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementEFCore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
