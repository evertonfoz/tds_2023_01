using Aula05.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula05.RazorPages.Data {
        public class AppDbContext : DbContext
    {
        public DbSet<EventModel>? Events { get; set; }
        public DbSet<PlayerModel>? Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<EventModel>().ToTable("Eventos").HasKey(e => e.EventID);
            modelBuilder.Entity<EventModel>().Property(e=>e.EventID).ValueGeneratedOnAdd();

            modelBuilder.Entity<PlayerModel>().ToTable("Jogadores").HasKey(j => j.PlayerID);
            modelBuilder.Entity<PlayerModel>().Property(p=>p.PlayerID).ValueGeneratedOnAdd();

            modelBuilder.Entity<EventModel>()
                .HasMany(e => e.Players)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EventoJogador",
                    j => j.HasOne<PlayerModel>().WithMany().HasForeignKey("PlayerID"),
                    e => e.HasOne<EventModel>().WithMany().HasForeignKey("EventID"),
                    eJ =>
                    {
                        eJ.HasKey("EventID", "PlayerID");
                        eJ.ToTable("EventosEJogadores");
                    });
        }
    }

}