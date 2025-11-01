using Microsoft.AspNetCore.RateLimiting;
using senhasegura.Interface;
using senhasegura.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddTransient<ISenhaService, SenhaService>();

builder.Services.AddRateLimiter(options =>
{
    options.AddSlidingWindowLimiter("fixed",o =>
    {
        o.PermitLimit = 5;
        o.Window = TimeSpan.FromSeconds(30);
        o.SegmentsPerWindow = 2;
    });
});  

builder.Services.AddCors(builder =>
{
    builder.AddPolicy("FrontendPolicy", policy =>
    {
        policy.WithOrigins("https://safepassword-five.vercel.app")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
}); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("FrontendPolicy");

app.UseRateLimiter();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }