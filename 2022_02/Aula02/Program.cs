using Aula02.Domain.Entities;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var estados = new List<EstadoEntity>()
{
    new EstadoEntity("PR", "Paraná"),
    new EstadoEntity("SC", "Santa Catarina", estadoID:1),
};

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

app.MapGet("/estados", () =>
{
    
    return estados;
})
.WithName("estados");

app.MapGet("/getbyuf/{uf}", (string uf) =>
{
    try
    {
        var estado = estados.First(e => e.UF.Equals(uf));
        return Results.Ok(estado);
    }
    catch (Exception)
    {
        return Results.NotFound($"Estado com UF {uf} não existe");
    }
});

app.MapPost("/estados", (EstadoEntity estado) =>
{
    estados.Add(estado);
});

app.MapDelete("/estados/{id}", (int id) =>
{
    var count = estados.RemoveAll(e => e.EstadoID == id);
    if (count == 0)
    {
        return Results.NotFound($"Estado com ID {id} não existe");
    }
    return Results.Ok();
});

app.MapPut("/estados", (EstadoEntity estado) =>
{
    try
    {
        estados.First(
            e => e.EstadoID.Equals(estado.EstadoID)).
            Update(estado.UF, estado.Nome);
        return Results.Ok();
    }
    catch (Exception)
    {
        return Results.NotFound($"Estado {estado} não existe");
    }
});




//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}