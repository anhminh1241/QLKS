using Microsoft.EntityFrameworkCore;
using QLKS.DbContext;
using QLKS.Repositories;
using QLKS.Repositories.Interfaces;
using QLKS.Services;
using QLKS.Services.Impls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))
);

builder.Services.AddTransient(typeof(IBaseRepo<,>), typeof(BaseRepo<,>));
builder.Services.AddTransient<IRoomRepo, RoomRepo>();
builder.Services.AddTransient<IRoomService, RoomService>();
builder.Services.AddTransient<IUserRepo, UserRepo>();
builder.Services.AddTransient<IRoomTypeRepo, RoomTypeRepo>();
builder.Services.AddTransient<IBookingRepo, BookingRepo>();
builder.Services.AddTransient<IUserService, UserService>();

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
