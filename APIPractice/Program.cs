using APIPractice.Data;
using RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository;
using ServiceLayer.BrandService;

var builder = WebApplication.CreateBuilder(args);


//DB context configiration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultconnectionString")));

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddTransient<IBrandService, BrandService>();

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


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
