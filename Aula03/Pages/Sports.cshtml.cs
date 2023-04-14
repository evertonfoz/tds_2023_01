using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aula03.Pages
{
    public class Sports : PageModel
    {
        private readonly ILogger<Sports> _logger;

        public Sports(ILogger<Sports> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}