using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess
{
    public class ToDoAppDbContext : DbContext
    {

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-many relationship between Status and ToDo
            modelBuilder.Entity<ToDo>()
                .HasOne(x => x.Status)
                .WithMany()
                .HasForeignKey(x => x.StatusId);

            modelBuilder.Entity<ToDo>()
                .Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<ToDo>()
                .Property(x => x.DueDate)
                .IsRequired();

            // one-to-many relationship between Category and ToDo
            modelBuilder.Entity<ToDo>()
                .HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId);

            //seed data for Status table
            modelBuilder.Entity<Category>()
               .HasData(
                   new Category { Id = 1, Name = "Work" },
                   new Category { Id = 2, Name = "Home" },
                   new Category { Id = 3, Name = "Exercise" },
                   new Category { Id = 4, Name = "Shopping" },
                   new Category { Id = 5, Name = "Hoby" },
                   new Category { Id = 6, Name = "FreeTime" }
               );

            modelBuilder.Entity<Status>()
                .HasData(
                     new Status { Id = 1, Name = "Open" },
                     new Status { Id = 2, Name = "Closed" }
                 );
            modelBuilder.Entity<ToDo>()
                .HasData(
                    new ToDo
                    {
                        Id = 1,
                        Description = "Finish project presentation",
                        DueDate = new DateTime(2026, 7, 17),
                        CategoryId = 1,
                        StatusId = 1
                    },
                    new ToDo
                    {
                        Id = 2,
                        Description = "Clean the house",
                        DueDate = new DateTime(2026, 7, 16),
                        CategoryId = 2,
                        StatusId = 1
                    },
                    new ToDo
                    {
                        Id = 3,
                        Description = "Morning exercise",
                        DueDate = new DateTime(2026, 7, 15),
                        CategoryId = 3,
                        StatusId = 2
                    },
                    new ToDo
                    {
                        Id = 4,
                        Description = "Buy groceries",
                        DueDate = new DateTime(2026, 7, 18),
                        CategoryId = 4,
                        StatusId = 1
                    },
                    new ToDo
                    {
                        Id = 5,
                        Description = "Watch a movie",
                        DueDate = new DateTime(2026, 7, 15),
                        CategoryId = 6,
                        StatusId = 2
                    }
                );


            base.OnModelCreating(modelBuilder);
        }


    }
}
