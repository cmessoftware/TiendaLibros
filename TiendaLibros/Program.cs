using Microsoft.EntityFrameworkCore;
using TiendaLibro.Common.Extensiones;
using TiendaLibro.Entidades;

var builder = WebApplication.CreateBuilder(args);


//Configuracion del EF Core.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

//Configuro el DBContext y el connection string.
builder.Services.AddDbContext<TiendaLibrosContext>(options =>
        options.UseSqlServer(connectionString)
);

//Configuro servicio agregados por DI.
//builder.Services.AddConfig
//Usa una método de extensión de IServiceCollection.
builder.Services.AddServices();
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
