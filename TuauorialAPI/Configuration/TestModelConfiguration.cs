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
            builder.Property(x => x.Created).HasColumnName("created").IsRequired();
            builder.Property(x => x.Sex).HasColumnName("sex").IsRequired();

        }
    }
}
