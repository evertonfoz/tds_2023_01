using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var tasks = new List<Tasks.API.Model.Task>
{
    new Tasks.API.Model.Task { Id = 1, Title = "Task 1", Description = "Description 1", Done = true },
    new Tasks.API.Model.Task { Id = 2, Title = "Task 2", Description = "Description 2", Done = false },
    new Tasks.API.Model.Task { Id = 3, Title = "Task 3", Description = "Description 3", Done = true }
};

builder.Services.AddSingleton(tasks);
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tasks.API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tasks.API v1");
//    c.RoutePrefix = string.Empty;
//});

app.MapGet("/tasks", () =>
{
    var taskService = app.Services.GetRequiredService<List<Tasks.API.Model.Task>>();
    return Results.Ok(taskService);
});

app.MapGet("/tasks/{id}", (int id, HttpRequest request) =>
{
    var taskService = app.Services.GetRequiredService<List<Tasks.API.Model.Task>>();
    var task = taskService.FirstOrDefault(t => t.Id == id);

    if (task == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(task);
});


app.MapPost("/tasks",  (Tasks.API.Model.Task task) =>
{
    var taskService = app.Services.GetRequiredService<List<Tasks.API.Model.Task>>();
    task.Id = taskService.Max(t => t.Id) + 1;
    taskService.Add(task);
    return Results.Created($"/tasks/{task.Id}", task);
});

app.MapPut("/tasks/{id}", (int id, Tasks.API.Model.Task task) =>
{
    var taskService = app.Services.GetRequiredService<List<Tasks.API.Model.Task>>();
    var existingTask = taskService.FirstOrDefault(t => t.Id == id);

    if (existingTask == null)
    {
        return Results.NotFound();
    }

    existingTask.Title = task.Title;
    existingTask.Description = task.Description;
    existingTask.Done = task.Done;

    return Results.NoContent();
});

app.MapDelete("/tasks/{id}",  (int id) =>
{
    var taskService = app.Services.GetRequiredService<List<Task>>();
    var existingTask = taskService.FirstOrDefault(t => t.Id == id);

    if (existingTask == null)
    {
        return Results.NotFound();
    }

    taskService.Remove(existingTask);

    return Results.NoContent();
});

app.Run();