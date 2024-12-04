using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NhienDentistry.Core.Catalog.Articles;
using NhienDentistry.Core.Catalog.Categories;
using NhienDentistry.Core.Common;
using NhienDentistry.Core.System.Languages;
using NhienDentistry.Core.System.Roles;
using NhienDentistry.Core.System.Users;
using NhienDentistry.Core.Utilities.Slides;
using NhienDentistry.DataBase.EF;
using NhienDentistry.DataBase.Entities;
using NhienDentistry.ViewModels.System.Users;

var builder = WebApplication.CreateBuilder(args);


// Add service collection
builder.Services.AddTransient<IStorageService, FileStorageService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IArticlesService, ArticlesService>();
builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<ISlideService, SlideService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ILanguageService, LanguageService>();
builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<NhienDbContext>()
                .AddDefaultTokenProviders();
// Add services to the container.

builder.Services.AddDbContext<NhienDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("NhienDentistryConnection");
    Console.WriteLine($"Connection String: {connectionString}");
    option.UseSqlServer(connectionString);
});
builder.Services.AddControllers();
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Nhien Dentistry", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                    });
});

string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
