using Aula05.RazorPages.Data;
using Aula05.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Aula04.RazorPages.Pages.Events
{
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        public List<EventModel> EventList { get; set;  } = new();
        
        public Index(AppDbContext context)
        {
          _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var httpClient = new HttpClient();
            var url = "http://localhost:5072/";
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await httpClient.SendAsync(requestMessage);
            // EventList = await response.Content.ReadAsStringAsync();
            var content = await response.Content.ReadAsStringAsync();

//dotnet add package Newtonsoft.Json

            EventList = JsonConvert.DeserializeObject<List<EventModel>>(content!);


            // EventList = await _context.Events!.ToListAsync();
            return Page();
        }
    }
}