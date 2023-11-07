using EmployeeWEBAPIJISAHW.Data;
using EmployeeWEBAPIJISAHW.Repositories;
using EmployeeWEBAPIJISAHW.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");

//assign the connection string to ApplicationDbContext class for CRUD
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(connectionString));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EmployeeWEBAPIJISAHW", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EmployeeWEBAPIJISAHW v1"));





app.Run();
