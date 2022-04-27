using CourseStore.Core.Domain.Courses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Courses.Configurations
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);

            builder.ToTable("Course");

            builder.OwnsOne(c => c.Price, c => 
            {
                c.Property(p => p.Price).HasColumnName("Price");
            });

            builder.HasMany(c => c.CourseTeachers)
                .WithOne();
        }
    }
}
