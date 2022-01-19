using Microsoft.EntityFrameworkCore;
using DL.Models;

namespace DL.Entity_Framework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewCriteria> ReviewCriterias { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypess { get; set; }
        

        public ApplicationContext()
        {
            /*Database.EnsureDeleted();*/
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=serviceappdb;Trusted_Connection=True;");
        }
    }
}
