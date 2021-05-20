using Microsoft.EntityFrameworkCore;
using System;

namespace FitTrackAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>().HasData(
                new Settings { Id = 1, UserId = 1, Unit = Unit.Imperial },
                new Settings { Id = 2, UserId = 2, Unit = Unit.Metric },
                new Settings { Id = 3, UserId = 3, Unit = Unit.Imperial },
                new Settings { Id = 4, UserId = 4, Unit = Unit.Imperial },
                new Settings { Id = 5, UserId = 5, Unit = Unit.Imperial });

            modelBuilder.Entity<Measurement>().HasData(
                new Measurement { Id = 1, UserId = 1, Waist = 40.5, Neck = 16.5, Hip = null, Weight = 223.0, Created = new DateTime(2021,05,13)   },
                new Measurement { Id = 2, UserId = 1, Waist = 40.5, Neck = 16.5, Hip = null, Weight = 223.0, Created = new DateTime(2021, 05, 13) },
                new Measurement { Id = 3, UserId = 1, Waist = 40.5, Neck = 16.5, Hip = null, Weight = 223.0, Created = new DateTime(2021, 05, 13) },
                new Measurement { Id = 4, UserId = 1, Waist = 40.5, Neck = 16.5, Hip = null, Weight = 223.0, Created = new DateTime(2021, 05, 13) },
                new Measurement { Id = 5, UserId = 1, Waist = 40.5, Neck = 16.5, Hip = null, Weight = 223.0, Created = new DateTime(2021, 05, 13) });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "adam@example.com", FirstName = "Adam", LastName = "Hernandez", Gender = Gender.Male, Height = 73.0, Created = new DateTime(2021, 05, 20) },
                new User { Id = 2, Email = "rudy@example.com", FirstName = "Rudy", LastName = "Hernandez", Gender = Gender.Male, Height = 75.0, Created = new DateTime(2021, 05, 20) },
                new User { Id = 3, Email = "daniel@example.com", FirstName = "Daniel", LastName = "Hernandez", Gender = Gender.Male, Height = 71.0, Created = new DateTime(2021, 05, 20) },
                new User { Id = 4, Email = "andrew@example.com", FirstName = "Andrew", LastName = "Hernandez", Gender = Gender.Male, Height = 68.0, Created = new DateTime(2021, 05, 20) },
                new User { Id = 5, Email = "aaron@example.com", FirstName = "Aaron", LastName = "Hernandez", Gender = Gender.Male, Height = 70.0, Created = new DateTime(2021, 05, 20) }
                );
        }
    }
}
