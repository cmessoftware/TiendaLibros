using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TiendaLibro.Entidades;
using TiendaLibro.Repositorios;
using TiendaLibro.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

//Configuro el DBContext y el connection string.
builder.Services.AddDbContext<TiendaLibrosContext>(options => 
        options.UseSqlServer("Data Source=(localdb)\\MSSQLServer;Initial Catalog=TiendaLibros-Clase")
);

//Configuro servicio agregados por DI.

builder.Services.AddScoped<ILibroServicios, LibroServicios>();
builder.Services.AddScoped<ILibroRepositorio, LibroRepositorio>();
//builder.Services.AddConfig

//Mappers
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
