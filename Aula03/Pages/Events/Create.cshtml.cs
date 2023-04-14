using Events.API.Models;
using Events.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aula03.Pages.Events
{
    public class Create : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public EventModel Event { get; set; } = new();

        public Create(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }
            var emptyEvent = new EventModel();

            if (await TryUpdateModelAsync<EventModel>(emptyEvent, 
            "event", 
            e => e.Name, e => e.Description, e => e.Date)) {
                var entry = _context.Add(emptyEvent);
                await _context.SaveChangesAsync();
                // entry.CurrentValues.SetValues(Event);
                return RedirectToPage("/Events/Index");
            }
            return Page();
        }
    }
}