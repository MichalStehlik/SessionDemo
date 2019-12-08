using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Adam", LastName = "Aladin", Classroom = "P3" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Bob", LastName = "Brumbál", Classroom = "P3" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Cyrus", LastName = "Casper", Classroom = "P3" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, FirstName = "Daniel", LastName = "Drakula", Classroom = "P3" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, FirstName = "Eve", LastName = "Elektra", Classroom = "P3" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 6, FirstName = "Filip", LastName = "Frankenstein", Classroom = "P3" });
        }
    }
}
