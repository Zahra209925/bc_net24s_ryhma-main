using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register AppDbContext with an in-memory database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("ProductsDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();



