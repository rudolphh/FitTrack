using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrackAPI.Models
{
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Measurements)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Settings)
                .WithOne(s => s.User)
                .HasForeignKey<Settings>(s => s.UserId);


            modelBuilder.Seed();

        }

        public DbSet<Measurement> Measurements { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
