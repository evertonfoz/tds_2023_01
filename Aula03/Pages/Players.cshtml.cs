using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aula03.Pages
{
    public class Players : PageModel
    {
        private readonly ILogger<Players> _logger;

        public Players(ILogger<Players> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}