using CEstado.Infra.Data.DatabaseContexts;
using Estados.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TDS.Api.Controllers
{
    [Route("api/[controller]")]
    public class EstadosController : ControllerBase
    {
        private EstadoDbContext _context;
        public EstadosController(EstadoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<EstadoEntity>>> Get()
        {
            return await _context.Estados.ToListAsync(); 
        }

        [HttpPost]
        public async Task<EstadoEntity> add([FromBody] EstadoEntity estado)
        {
            _context.Add(estado);
            await _context.SaveChangesAsync();
            return estado;
        }

        [HttpPut]
        public async Task<EstadoEntity> update([FromBody] EstadoEntity estado)
        {
            try
            {
                EstadoEntity? result = await _context.FindAsync<EstadoEntity>(estado.EstadoID);
                result.UF = estado.UF;
                result.Nome = estado.Nome;

                _context.Entry<EstadoEntity>(result).State =
                                       EntityState.Modified;
                await _context.SaveChangesAsync();
                return estado;
            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
