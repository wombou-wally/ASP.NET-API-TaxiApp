using Microsoft.EntityFrameworkCore;
using TaxiApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaxiDBContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=taxidb;Username=postgres;Password=6679327"));
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
