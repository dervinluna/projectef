using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectoef;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));      para usar base de datos en memoria
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) => 
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
