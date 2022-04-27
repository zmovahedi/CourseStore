using CourseStore.Core.Domain.Comments.Entities;
using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Tags.Entities;
using CourseStore.Core.Domain.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Contexts
{
    public class CourseStoreDbContext : DbContext
    {
        public CourseStoreDbContext(DbContextOptions<CourseStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<CourseComment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    modelBuilder.Entity(entityType.ClrType).Property<string>("CreatedBy")
            //        .HasMaxLength(50);
            //}
        }

    }
}
