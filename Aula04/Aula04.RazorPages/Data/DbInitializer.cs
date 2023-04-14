using Aula04.RazorPages.Models;

namespace Aula04.RazorPages.Data {
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Events!.Any())
            {
                var events = new EventModel[] {
                    new EventModel{
                        Name ="Torneio de truco",
                        Description = "Campeonado acadêmico de CC da UTFPR",
                        Date = DateTime.Parse("2023-04-01")
                    },
                };
                context.AddRange(events);
            }



            if (!context.Players!.Any())
            {
                var players = new PlayerModel[] {
                    new PlayerModel{
                        Name = "Pelé",
                        Age = 18
                    },
                };
                context.AddRange(players);
            }

            context.SaveChanges();
        }
    }
}