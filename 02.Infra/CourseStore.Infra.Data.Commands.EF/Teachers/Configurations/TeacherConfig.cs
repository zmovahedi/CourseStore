using CourseStore.Core.Domain.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Teachers.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.OwnsOne(t => t.FullName, t =>
            {
                t.Property(f => f.FirstName).HasMaxLength(100).HasColumnName("FirstName");
                t.Property(f => f.LastName).HasMaxLength(200).HasColumnName("LastName");
            });
        }
    }
}
