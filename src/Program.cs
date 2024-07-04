using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Services;
using Coffee_Shop_App.src.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddScoped<IUserService, UserService>(); //this is the built-in DI container for the Service
builder.Services.AddScoped<IUserRepository, UserRepository>(); //this is the built-in DI container for the Repository

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();