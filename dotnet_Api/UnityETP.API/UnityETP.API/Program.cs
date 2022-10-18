
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders;
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
builder.Services.AddSwaggerGen();
var dbconnection = builder.Configuration.GetConnectionString("Local");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(dbconnection);
});
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


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
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
});
builder.Services.Configure<PasswordHasherOptions>(option => { option.IterationCount = 12000; });

builder.Services.AddOptions<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme)
    .Configure<ITicketStore>((options, store) => {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.SessionStore = store;
    });

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
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
