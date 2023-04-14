using Events.API.Models;
using Events.Data;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Get(
            [FromServices] AppDbContext context) => 
                Ok( context.Events!.ToList());

        [HttpGet("/{id:int}")]
        public IActionResult GetById([FromRoute] int id,
            [FromServices] AppDbContext context)
        {
            var eventModel = context.Events!.FirstOrDefault(x => x.Id == id);
            if (eventModel == null) {
                return NotFound();
            }

            return Ok(eventModel);
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] EventModel eventModel,
            [FromServices] AppDbContext context)
        {
            context.Events!.Add(eventModel);
            context.SaveChanges();
            return Created($"/{eventModel.Id}", eventModel);
        }

        [HttpPut("/")]
        public IActionResult Put([FromRoute] int id, 
            [FromBody] EventModel eventModel,
            [FromServices] AppDbContext context)
        {
            var model =context.Events!.FirstOrDefault(x => x.Id == id);
            if (model == null) {
                return NotFound();
            }

            model.Name = eventModel.Name;
            model.Description = eventModel.Description;
            model.Date = eventModel.Date;

            context.Events!.Update(model);
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("/")]
        public IActionResult Delete([FromRoute] int id, 
            [FromServices] AppDbContext context)
        {
            var model =context.Events!.FirstOrDefault(x => x.Id == id);
            if (model == null) {
                return NotFound();
            }

            context.Events!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
    
}