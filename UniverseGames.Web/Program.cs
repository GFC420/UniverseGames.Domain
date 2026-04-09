using Microsoft.EntityFrameworkCore;
using UniverseGames.Application;
using UniverseGames.Infrastructure;
using UniverseGames.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

//conexão com banco
builder.Services.AddDbContext<GameDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//injeção de dependicias
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<GameService>();

builder.Services.AddRazorPages();


builder.Services.AddControllers();

var app =  builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.MapRazorPages();

app.Run();