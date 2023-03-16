using ExamProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
var config = builder.Configuration.GetSection("ConnectionToExam");
builder.Services.AddDbContext<ProductDbContext>(option => option.UseNpgsql(config["Connection"]));
builder.Services.AddScoped<ProductDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
