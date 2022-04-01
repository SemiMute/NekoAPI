using Microsoft.EntityFrameworkCore;
using NekoQOLWebAPI.Context;
using NekoQOLWebAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NekoDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SQLite")));

builder.Services.AddScoped<IHypixelPlayerRespository, HypixelPlayerRepository>();

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
