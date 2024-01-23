using Microsoft.EntityFrameworkCore;
using OnlineShopping.Businnes.IServices;
using OnlineShopping.Businnes.Mappers;
using OnlineShopping.Businnes.Services;
using OnlineShopping.Infrastructure.Datas;
using OnlineShopping.Infrastructure.IRepositories;
using OnlineShopping.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ShoppingCONNString"));
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddAutoMapper(typeof(UserMapper));

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
