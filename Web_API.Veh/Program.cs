using DAL.Veh;
using DAL.Veh.Implementation;
using DAL.Veh.Interface;
using DAL.Veh.Model;
using Microsoft.EntityFrameworkCore;
using Service.Veh.Implementation;
using Service.Veh.Interface;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<VehDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<DbContext, VehDbContext>();

// Add services to the container.

builder.Services.AddScoped<IRepository<Vehicle>, Repository<Vehicle>>();
builder.Services.AddScoped<IVehService, VehService>();


builder.Services.AddControllers();


//Add Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});



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

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
