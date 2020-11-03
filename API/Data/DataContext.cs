using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .Property(t => t.IsDone)
                .HasDefaultValue(false);

            modelBuilder.Entity<Todo>()
                .HasData(
                    new Todo {Id = 1, Description= "Task1", Created= DateTime.Now},
                    new Todo {Id = 2, Description= "Task2", Created= DateTime.Now},
                    new Todo {Id = 3, Description= "Task3", Created= DateTime.Now},
                    new Todo {Id = 4, Description= "TAsk4", Created= DateTime.Parse("10/11/2020")}
                );
        }
    }
}