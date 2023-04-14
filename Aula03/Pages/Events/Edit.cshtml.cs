using Events.API.Models;
using Events.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aula03.Pages.Events
{
    public class Edit : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public EventModel Event { get; set; } = default!;

        public Edit(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Events == null) {
                return NotFound();
            } 
            
            Event =  await _context.Events.FindAsync(id);

            if (Event == null) {
                return NotFound();
            } 
            
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id) {
            if (!ModelState.IsValid) {
                return Page();
            }
            var emptyEvent = await _context.Events.FindAsync(id);

            if (emptyEvent == null) {
                return NotFound();
            } 

            if (await TryUpdateModelAsync<EventModel>(emptyEvent, 
            "event", 
            e => e.Name, e => e.Description, e => e.Date)) {
                // var entry = _context.Add(emptyEvent);
                // entry.CurrentValues.SetValues(Event);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Events/Index");
            }
            return Page();
        }
    }
}