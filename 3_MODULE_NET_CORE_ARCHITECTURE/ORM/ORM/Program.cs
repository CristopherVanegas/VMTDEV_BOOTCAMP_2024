using Microsoft.EntityFrameworkCore;
using ORM.Interface;
using ORM.Models;
using ORM.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Relaciona entre el servicio y la interfaz
builder.Services.AddScoped<IProducto, ProductoService>();

builder.Services.AddDbContext<VentasContext>(opciones =>
opciones.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
