using Microsoft.EntityFrameworkCore;
using TuauorialAPI.Configuration;
using TuauorialAPI.Models;

namespace TuauorialAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

        public DbSet<TestModel>? TestModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestModelConfiguration());
        }

    }
}
