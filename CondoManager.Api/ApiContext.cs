using Microsoft.EntityFrameworkCore;

using CondoManager.Api.Data.Models;

namespace CondoManager.Api {
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ShopBussiness> ShopBussiness { get; set; }
        public DbSet<ShopContact> ShopContacts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Condominium> Condominiums { get; set; }
        public DbSet<Condominium> CondominiumSupervisors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=CondoManagerDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies)
                .WithOne(e => e.Owner)
                .HasForeignKey(e => e.OwnerId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Condominiums)
                .WithOne(e => e.Manager)
                .HasForeignKey(e => e.ManagerId)
                .IsRequired();
        }
    }
}