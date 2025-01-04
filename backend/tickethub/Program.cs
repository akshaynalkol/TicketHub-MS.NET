using tickethub.Repositories;
using tickethub.Repositories.Interfaces;
using tickethub.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserRepository,IUserRepository>();
builder.Services.AddScoped<IUserService,IUserService>();

builder.Services.AddControllers();

var app = builder.Build();

// Ensure the database is created
using (var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();  // Creates the DB if it doesn't exist
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
