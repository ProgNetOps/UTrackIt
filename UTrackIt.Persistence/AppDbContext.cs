using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTrackIt.Domain;

namespace UTrackIt.Persistence
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Circuit_BTS>().HasKey(cb => new
            //{
            //    cb.CircuitId,
            //    cb.BTSId
            //});

            //modelBuilder.Entity<Circuit_BTS>().HasOne(b => b.Circuit).WithMany(cb => cb.Circuit_BTS).HasForeignKey(b => b.CircuitId).OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<Circuit_BTS>().HasOne(b => b.BTS).WithMany(cb => cb.Circuit_BTS).HasForeignKey(b => b.BTSId).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            //To set cascading referential integrity constraint to NO ACTION on Delete
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<LinkStatus> LinkStatuses { get; set; }
        public DbSet<CircuitState> CircuitStates { get; set; }
        public DbSet<ClientCategory> ClientCategories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
