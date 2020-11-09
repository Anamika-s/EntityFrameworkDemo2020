using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(p => p.CourseId);
            modelBuilder.Entity<Course>().Property(c => c.CourseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Student>().HasKey(b => b.Id);
            modelBuilder.Entity<Student>().Property(b => b.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Student>().HasRequired(p => p.Course)
                .WithMany(b => b.Students).HasForeignKey(b => b.CourseId);

            base.OnModelCreating(modelBuilder);
        }

    }
}