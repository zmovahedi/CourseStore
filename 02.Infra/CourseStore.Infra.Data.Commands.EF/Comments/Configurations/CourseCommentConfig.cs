using CourseStore.Core.Domain.Comments.Entities;
using CourseStore.Core.Domain.Courses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Comments.Configurations
{
    public class CourseCommentConfig : IEntityTypeConfiguration<CourseComment>
    {
        public void Configure(EntityTypeBuilder<CourseComment> builder)
        {
            builder.Property(c => c.CommentBy).HasMaxLength(100);
            builder.Property(c => c.Comment).HasMaxLength(500);

            builder.ToTable("CourseComment");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey(c => c.CourseId);
        }
    }
}
