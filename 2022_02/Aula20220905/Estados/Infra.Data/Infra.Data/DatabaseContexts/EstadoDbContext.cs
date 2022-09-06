using Estados.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CEstado.Infra.Data.DatabaseContexts
{
    public class EstadoDbContext : DbContext
    {
        public EstadoDbContext(DbContextOptions<EstadoDbContext> options)
                : base(options)
        {
            //ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public virtual DbSet<EstadoEntity> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<EstadoEntity>().ToTable("Estados");
        }
    }
}