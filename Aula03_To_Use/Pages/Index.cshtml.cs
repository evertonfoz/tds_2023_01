using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aula03_To_Use.Pages;

public class Index : PageModel
{
    private readonly ILogger<Index> _logger;
    public List<EventModel> Events { get; set; } = new();

    public Index(ILogger<Index> logger)
    {
        _logger = logger;
    }

    public async Task OnGet(int skip=0, int take=25)
    {
        await Task.Delay(3000);
        List<EventModel> events = new();

        for (int i = 0; i < 500; i++)
        {
            events.Add(
                new EventModel(
                    i, $"Evento {i}", $"Descrição {i}", DateTime.Now
                )
            );
        }

        Events = events.Skip(skip).Take(take).ToList();

    }
}

public record EventModel(
     int? Id,
     string Name,
     string Description,
     DateTime Date
);
