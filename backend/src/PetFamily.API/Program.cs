using PetFamily.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped <ApplicationDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
