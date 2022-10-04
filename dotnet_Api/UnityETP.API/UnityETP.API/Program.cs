
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var dbconnection = builder.Configuration.GetConnectionString("Local");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(dbconnection);
});
//builder.Services.AddIdentity<AppUser, AppRole>()
//    .AddEntityFrameworkStores<AppDbContext>()
//    .AddDefaultTokenProviders();


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
