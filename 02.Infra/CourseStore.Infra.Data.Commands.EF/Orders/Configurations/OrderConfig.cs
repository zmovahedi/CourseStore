using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Orders.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.OwnsOne(o => o.Price, o =>
            {
                o.Property(p => p.Price).HasColumnName("Price");
            });
            builder.OwnsOne(o => o.OrderDate, o =>
            {
                o.Property(d => d.Date).HasColumnName("OrderDate");
            });
            builder.OwnsOne(o => o.CustomerEmail, o => 
            {
                o.Property(e => e.Value).HasMaxLength(100).HasColumnName("CustomerEmail");
            });

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey(o => o.CourseId);
        }
    }
}
