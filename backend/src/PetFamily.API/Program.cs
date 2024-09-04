using PetFamily.Application.Volunteers;
using PetFamily.Application.Volunteers.CreateVolunteer;
using PetFamily.Infrastructure;
using PetFamily.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped <ApplicationDbContext>();

builder.Services.AddScoped<CreateVolunteerService>();
builder.Services.AddScoped<IVolunteersRepository, VolunteersRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
