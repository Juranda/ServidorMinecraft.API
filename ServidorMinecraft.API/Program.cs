using Microsoft.EntityFrameworkCore;
using ServidorMinecraft.API.Data;
using ServidorMinecraft.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MinecraftServerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ServerDb")));

builder.Services.AddScoped<IPetTypeRepository, PetTypeRepository>();

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
