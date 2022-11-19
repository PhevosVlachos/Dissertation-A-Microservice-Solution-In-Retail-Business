

using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyEshopDbContext>(options =>
        options.UseMySQL(builder.Configuration.GetConnectionString("MyConn")));
builder.Services.AddScoped<IForecast, Forecast>();
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
//comment
