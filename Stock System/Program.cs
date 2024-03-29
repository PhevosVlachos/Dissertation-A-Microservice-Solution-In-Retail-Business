

using Microsoft.EntityFrameworkCore;

using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.Services;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("MyConn");
builder.Services.AddDbContext<CatalogDbContext>(options =>
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));



builder.Services.AddScoped<IProductService, ProductService>();




//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("Policy1", policyBuilder =>
//    {
//        if (builder.Environment.IsDevelopment())
//            policyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//        else
//            policyBuilder.WithOrigins("https://localhost:7103/")
//                .AllowAnyMethod().AllowAnyHeader();
//    });
//});



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Policy1",
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7103")
                .AllowAnyMethod().AllowAnyHeader();
                      });
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();


app.UseCors("Policy1");


app.UseAuthorization();

app.MapControllers();


app.Run();


//commentootoot