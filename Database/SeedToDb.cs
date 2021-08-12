using System;
using EventLogin.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventLogin.Database
{
    public static class SeedToDb
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            FillUsers(modelBuilder);
            FillEvents(modelBuilder);
        }
        
        private static void FillUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Peter",
                    DSize = 2,
                    Email = "fickwurst@schnitzel.de"
                },
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Jürgen",
                    DSize = 12,
                    Email = "schnitzel@fickwurst.de"
                }
            );
        }
        
        private static void FillEvents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventEntity>().HasData(
                new EventEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Volksfest",
                    Date = DateTime.Now,
                    Location = "Berlin",
                    MaxUsers = 20
                    
                },
                new EventEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Blackroom",
                    Date = DateTime.Now,
                    Location = "Dortmund",
                    MaxUsers = 30
                }
            );
        }
        

    }
}