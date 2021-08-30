using EventLogin.Entities;
using EventLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace EventLogin.Database
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        
        // the dbset propterty will tell ef core that we habe a table that needs to be created id doesnt exist
        public virtual DbSet<User> Users { get; set; }
        
        public DbSet<UserEntity> User { get; set; }
        public DbSet<EventEntity> Event { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Event.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}