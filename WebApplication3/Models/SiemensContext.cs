using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models

{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database =MVC ; Trusted_Connection = True;");
        }

        public DbSet<Suppliers> Suppliers { get; set; }

    }
}
