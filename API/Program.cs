using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TFGBackend.Data;
using TFGBackend.Business;
using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<TFGContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddScoped<IUsuarioRepository, UsuarioEFRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();



var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API v1");
});

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5025")
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials();
});

app.UseAuthorization();
app.MapControllers();
app.Run();

