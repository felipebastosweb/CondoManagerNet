using Microsoft.EntityFrameworkCore.SQLServer;


namespace CondoManager.Api {
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Condominium> Condominiums { get; set; }
        public DbSet<Condominium> CondominiumSupervisors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=CondoManagerDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}