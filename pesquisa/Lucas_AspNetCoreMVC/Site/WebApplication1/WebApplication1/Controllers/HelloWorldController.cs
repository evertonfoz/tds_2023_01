using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
           // return "Este é a Action padrão";
        }

        public string BemVindo(string nome, int numVezes = 1)
        {
            //return "Este é um método Action BemVindo";
            return HtmlEncoder.Default.Encode($"Ola {nome}, NumVezes igual a : {numVezes}");
        }
    }
}
