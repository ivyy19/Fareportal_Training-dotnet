using firstapi.Model;
using firstapi.Repository;
using firstapi.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Ace52024Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICustomer<CustomerIvy>,CustRepo>();
builder.Services.AddScoped<ICustServ<CustomerIvy>,CustServ>();

builder.Services.AddScoped<IFlight<FlightsIvy>,FlightRepo>();
builder.Services.AddScoped<IFlightServ<FlightsIvy>,FlightServ>();

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