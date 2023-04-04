using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TuauorialAPI.Models;

namespace TuauorialAPI.Configuration
{
    public class TestModelConfiguration : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.Age).HasColumnName("age").IsRequired();
            builder.Property(x => x.Created).HasColumnName("created").IsRequired()
                .HasConversion
            (
                src => src.Kind == DateTimeKind.Utc ? src : DateTime.SpecifyKind(src, DateTimeKind.Utc),
                dst => dst.Kind == DateTimeKind.Utc ? dst : DateTime.SpecifyKind(dst, DateTimeKind.Utc)
            );;
            builder.Property(x => x.Sex).HasColumnName("sex").IsRequired();
            builder.HasData(new TestModel[]
            {
                new (1,"danyl",22,DateTime.Now, "male")
            });
            
            
        }
    }
}
