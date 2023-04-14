using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aula03_To_Use.Pages
{
    public class Participantes : PageModel
    {
        private readonly ILogger<Participantes> _logger;

        public Participantes(ILogger<Participantes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}