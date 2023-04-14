using Events.API.Models;
using Events.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aula03.Pages.Events
{
    public class Details : PageModel
    {
        private readonly AppDbContext _context;
        public EventModel? Event { get; set; }
       
        public Details(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Events == null) {
                return NotFound();
            } 
            
            var eventModel =  await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);

            if (eventModel == null) {
                return NotFound();
            } 
            Event = eventModel;
            
            return Page();
        }

    }
}