using CourseStore.Core.Domain.Tags.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Tags.Configurations
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.TagName).IsRequired().HasMaxLength(100);
            
            builder.ToTable("Tag");

            builder.HasMany(c => c.CourseTags)
                .WithOne();
        }
    }
}
