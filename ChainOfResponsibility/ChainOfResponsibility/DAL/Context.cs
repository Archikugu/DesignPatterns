using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4K38GM2;initial catalog= ChainOfResponsibility; integrated security = true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
