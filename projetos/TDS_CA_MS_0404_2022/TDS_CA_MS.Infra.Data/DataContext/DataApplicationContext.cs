using Microsoft.EntityFrameworkCore;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Infra.Data.DataContext
{
    public class DataApplicationContext : DbContext
    {
        public DataApplicationContext(
            DbContextOptions<DataApplicationContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(DataApplicationContext).Assembly);
        }
    }
}
