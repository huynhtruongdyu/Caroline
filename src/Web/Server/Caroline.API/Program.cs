using Caroline.Application.Interfaces.Repositories;
using Caroline.Application.Profiles;
using Caroline.Infrastructure.Contexts;
using Caroline.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddMediatR(typeof(AppDbContext).Assembly);
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Health Check
builder.Services.AddHealthChecks();

//Auto Mapper
builder.Services.AddAutoMapper(typeof(CoreProfile).Assembly);

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

app.MapHealthChecks("/healthz");

app.Run();