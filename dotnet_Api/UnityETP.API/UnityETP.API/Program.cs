
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using UnityETP.API.Helpers;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => new OpenApiInfo
{
    Version = "v1",
    Title = "Unity E-commerce Api",
    Description = "Unity E-commerce",
    TermsOfService = new Uri("https://github.com/DrMadWill/RepositoryPattern"),
    Contact = new OpenApiContact
    {
        Name = "Nofel Salahov (DR Mad Will)",
        Email = "nofelsalahov9@gmail.com",
        Url = new Uri("https://www.linkedin.com/in/drmadwill/")
    }
});
var dbconnection = builder.Configuration.GetConnectionString("Local");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(dbconnection);
});
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.RegisterAppServices();

var issuer = builder.Configuration["Jwt:Issuer"];
var audience = builder.Configuration["Jwt:ValidAudience"];
var seckretKey = builder.Configuration["Jwt:SecretKey"];

// JWT authentication, used in api controllers //
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
        options =>
        {
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = ApiToken
            .CreateTokenValidationParameters(issuer, audience, seckretKey);
        });


builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(30);
});
builder.Services.Configure<PasswordHasherOptions>(option => { option.IterationCount = 12000; });


builder.Services.Configure<WebEncoderOptions>(options =>
{
    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
});

builder.Services.RegisterAppServices();

builder.Services.AddMemoryCache();

// Loop Add ignore
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
       options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

// 150 MB
const int maxRequestLimit = 157286400;
// If using IIS
builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = maxRequestLimit;
});
// If using Kestrel
builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = maxRequestLimit;
});
builder.Services.Configure<FormOptions>(x =>
{
    x.ValueLengthLimit = maxRequestLimit;
    x.MultipartBodyLengthLimit = maxRequestLimit;
    x.MultipartHeadersLengthLimit = maxRequestLimit;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Repository Pattern API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
