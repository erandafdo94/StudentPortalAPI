using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentPortalAPI.DataModels;
using StudentPortalAPI.Repository;
using StudentPortalAPI.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StudentAdminContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdminPortalDb")));

//DI
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfiles());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

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
