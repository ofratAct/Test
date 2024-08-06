using App.API.Profiles;
using App.BusinessLogic.Interfaces;
using App.BusinessLogic.Profiles;
using App.BusinessLogic.Services;
using App.DataAccess.DataContext;
using App.DataAccess.Interfaces;
using App.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        // Allow any domain- *  or only specific domain-http://localhost:3000
        policy.WithOrigins("*")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});


builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();


builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IProductsService, ProductsService>();

builder.Services.AddDbContext <ShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sql"));
});

builder.Services.AddAutoMapper(typeof(UserProfile).Assembly, typeof(ClientUserProfile).Assembly);


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
