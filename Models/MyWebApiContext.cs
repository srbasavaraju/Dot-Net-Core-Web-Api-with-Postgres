using Microsoft.EntityFrameworkCore;

namespace WebApiWithPostGress.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> users { get; set; }

        public DbSet<Employee> employeee { get; set; }

        public DbSet<Patient> patients { get; set; }
    }
}
