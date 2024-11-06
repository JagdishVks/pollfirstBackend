using Pollfirst.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add CORS services

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", builder =>
    {
        builder.WithOrigins("http://localhost:3000") // Your React app's URL
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials(); // Allow credentials (cookies, authorization headers, etc.)
    });
});

// Add services to the container.
//builder.Services.AddDbContext<NewsPlatformsArticlesContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));

// Add DbContext with SQL Server connection
builder.Services.AddDbContext<NewsArticleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<NewsPlatformTwitterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<InstagramPlatformContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<NewsPlatformFacebookContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<NewsPlatformYouTubeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<TrackLeaderContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));
// Add DbContext with SQL Server connection
builder.Services.AddDbContext<NewsPlatformArchiveContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pollfirst")));



builder.Services.AddControllers();

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Use the CORS policy
app.UseCors("AllowSpecificOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
//Optional: Add Swagger in production if needed
     app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
