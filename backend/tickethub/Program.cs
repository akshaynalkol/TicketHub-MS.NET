using tickethub.Helper;
using tickethub.Repositories;
using tickethub.Repositories.Implementations;
using tickethub.Repositories.Interfaces;
using tickethub.Services.Implementations;
using tickethub.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Ensure the database is created
using (var context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();  // Creates the DB if it doesn't exist
}

// Configure the HTTP request pipeline.
app.UseCors("AllowAll");
app.UseMiddleware<JwtMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
