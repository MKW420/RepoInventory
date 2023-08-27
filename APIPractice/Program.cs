
using RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository;
using ServiceLayer.BrandService;
using Microsoft.OpenApi.Models;
using ServiceLayer.CategoryService;
using ServiceLayer.ProductService;
using ServiceLayer.SupplierService;
using System.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ServiceLayer.UserService;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);


//DB context configiration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString"),
    npgsqlOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure();
    }));

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));


builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
   .AddJwtBearer(options =>
   {
       options.TokenValidationParameters = new TokenValidationParameters
       {
           //Validates the server
           ValidateIssuer = false,
           //reciepent of the token
           ValidateAudience = false,
           //checks if token is expired
          // ValidateLifetime = true,
        //   ValidIssuer = builder.Configuration["Jwt:Issuer"],
       //    ValidAudience = builder.Configuration["Jwt:Audience"],
           //validates the signature of the token
           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value))

       };
   });
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen( c =>
{
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme(\"bearer {token}\")",
       In = ParameterLocation.Header,
       Name = "Authorization",
       Type = SecuritySchemeType.ApiKey
    
    
    });

    c.OperationFilter<SecurityRequirementsOperationFilter>();

    c.SwaggerDoc("v1", new OpenApiInfo { Title = "InventorySystem", Version = "v1" });
}
    
    //GENERATE TOKEN CODE

    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI( c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InventorySystem v1"));
}


app.UseAuthentication();

app.UseAuthorization();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
