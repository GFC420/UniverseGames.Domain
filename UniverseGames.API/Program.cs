using Microsoft.EntityFrameworkCore;
using UniverseGames.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔥 Controllers
builder.Services.AddControllers();

// 🔥 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔥 BANCO SQL SERVER (AQUI 👇)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        "Server=(localdb)\\MSSQLLocalDB;Database=UniverseGamesDB;Trusted_Connection=True;TrustServerCertificate=True;",
        b => b.MigrationsAssembly("UniverseGames.Infrastructure")
    )
);

var app = builder.Build();

// 🔥 SEED AUTOMÁTICO
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await DatabaseSeeder.SeedAsync(db);
}

// 🔥 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🔥 Controllers
app.MapControllers();

app.Run();