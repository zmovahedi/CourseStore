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
    public class CourseTeacherConfig : IEntityTypeConfiguration<CourseTeacher>
    {
        public void Configure(EntityTypeBuilder<CourseTeacher> builder)
        {
            builder.ToTable("CourseTeacher");
        }
    }
}
