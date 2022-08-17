using System.Data.SqlClient;
using TDS_Docker_API_Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
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

app.MapGet("/Estabelecimentos/", () =>
    {
        SqlConnection connection = new SqlConnection(
            app.Configuration.GetConnectionString("TDS_DB"));

        SqlCommand command = new SqlCommand(
            "select ESTABELECIMENTOID, NOME from ESTABELECIMENTOS",
            connection);

        connection.Open();
        SqlDataReader sqlDataReader = command.ExecuteReader();
        IList<Estabelecimento> estabelecimentos = new List<Estabelecimento>();
        while(sqlDataReader.Read())
        {
            Estabelecimento estabelecimento = new();
            estabelecimento.EstabelecimentoID = sqlDataReader.GetInt32(0);
            estabelecimento.Nome = sqlDataReader.GetString(1);

            estabelecimentos.Add(estabelecimento);
        }
        connection.Close();

        return Results.Ok(estabelecimentos);
    }
);  

app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
