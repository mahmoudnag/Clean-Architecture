using Microsoft.EntityFrameworkCore;
using School.Infastructure.Data;
using School.Infastructure;
using School.Service;
using System;
using School.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string? connectionString = builder.Configuration.GetConnectionString("cs");
builder.Services.AddDbContext<ApplicationDBContext>(
    OptionsBuilder => { OptionsBuilder.UseSqlServer(connectionString); }

    );
#region servicesExtentions

builder.Services.AddModuleInfatructureDependencies()
                .AddModuleSerivesDependencies()
                .AddModuleCoreDependencies();
#endregion
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
