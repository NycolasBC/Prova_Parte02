using CartasNoel.Catalogo.Application.Interfaces;
using CartasNoel.Catalogo.Application.Services;
using CartasNoel.Catalogo.Data.Repository;
using CartasNoel.Catalogo.Domain.Interfaces;
using H1Store.Catalogo.Application.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddScoped<ICartasRepository, CartasRepository>();
builder.Services.AddScoped<ICartasServices, CartasServices>();


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
