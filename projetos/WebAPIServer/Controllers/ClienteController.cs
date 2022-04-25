using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIServer.Models;

namespace WebAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            var clientes = new List<Cliente>()
            {
                new Cliente() { 
                    ClienteID = 1, 
                    Nome="Asdrubal"
                },
                new Cliente() {
                    ClienteID = 2,
                    Nome="Gerbrásio"
                }
            };

            return Ok(clientes);
        }
    }
}
