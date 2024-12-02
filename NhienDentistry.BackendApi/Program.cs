using Microsoft.EntityFrameworkCore;
using NhienDentistry.Core.Catalog.Categories;
using NhienDentistry.DataBase.EF;

var builder = WebApplication.CreateBuilder(args);


// Add service collection
builder.Services.AddTransient<ICategoryService, CategoryService>();
// Add services to the container.

builder.Services.AddDbContext<NhienDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("NhienDentistryConnection");
    Console.WriteLine($"Connection String: {connectionString}");
    option.UseSqlServer(connectionString);
});
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

app.UseAuthorization();

app.MapControllers();

app.Run();
