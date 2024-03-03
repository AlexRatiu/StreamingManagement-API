using StreamingManagement.DAL.Initialization;
using StreamingManagement.Services;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DALStartup.Init(builder.Configuration, builder.Services);

builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IDistributionService, DistributionService>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IProviderService, ProviderService>();
builder.Services.AddTransient<IShowService, ShowService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
