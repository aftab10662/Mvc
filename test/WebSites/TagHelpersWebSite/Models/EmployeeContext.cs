using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using TagHelpersWebSite.Models;

    public class EmployeeContext : DbContext
    {
        private static bool _created = false;

        public EmployeeContext()
        {
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
