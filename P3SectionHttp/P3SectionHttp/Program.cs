using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using P3SectionHttp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<P3SectionHttpContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("P3SectionHttpContext") ?? throw new InvalidOperationException("Connection string 'P3SectionHttpContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
