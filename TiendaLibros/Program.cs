using System.Xml;
using TiendaLibro.Entidades;
using TiendaLibro.Mapeos.Resolvers;
using TiendaLibro.Repositorios;
using TiendaLibro.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging();

//Configuro servicio agregados por DI.
builder.Services.AddDbContext<TiendaLibrosContext>();
builder.Services.AddScoped<ILibroServicios, LibroServicios>();
builder.Services.AddScoped<ILibroRepositorio, LibroRepositorio>();

//Mappers
builder.Services.AddTransient<LibroDetallesResolver>();
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
