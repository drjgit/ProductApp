using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductDomain;
using ProductInfrastructure;
using ProductInfrastructure.dbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDBContext>((DbContextOptionsBuilder opt) => 
{
    opt.UseNpgsql(builder.Configuration.GetSection(key:"DBConnect").Value);
});

// ×¢Èë²Ö¿â²ã
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// ÅäÖÃ¿çÓò
builder.Services.AddCors((CorsOptions opts) => 
{
    opts.AddDefaultPolicy((CorsPolicyBuilder policybuiler) => 
    {
        policybuiler.WithOrigins(new string[] { "http://localhost:5104" }).AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
