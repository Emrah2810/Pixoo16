using Microsoft.EntityFrameworkCore;
using Pixoo16Lib.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// ? Console-uitvoer bij opstarten
Console.WriteLine("=======================================");
Console.WriteLine("API gestart op: https://localhost:5001");
Console.WriteLine("Swagger beschikbaar op: /swagger");
Console.WriteLine("Druk op Ctrl+C om te stoppen.");
Console.WriteLine("=======================================");

app.Run();
