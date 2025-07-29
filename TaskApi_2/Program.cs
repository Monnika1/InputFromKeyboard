using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

var tasks = new List<TaskItem>
{
    new TaskItem(1, "Task 1", "Description for Task 1"),
    new TaskItem(2, "Task 2", "Description for Task 2")
};
var nextId = 3;
app.MapGet("api/tasks", () => tasks);

app.MapGet("api/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    return task is not null ? Results.Ok(task) : Results.NotFound();
});
app.MapPost("api/tasks", (TaskItem task) =>
{
    task = task with { Id = nextId++ };
    tasks.Add(task);
    return Results.Created($"/api/tasks/{task.Id}", task);
});
app.MapPut("api/tasks/{id}", (int id, TaskItem updatedTask) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task is null) return Results.NotFound();

    var index = tasks.IndexOf(task);
    tasks[index] = updatedTask with { Id = id };

    return Results.NoContent();
});
app.MapDelete("api/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task is null) return Results.NotFound();

    tasks.Remove(task);
    return Results.NoContent();
});
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.Run();

public record TaskItem(int Id, [Required] string Title, string Description, bool IsCompleted = false);