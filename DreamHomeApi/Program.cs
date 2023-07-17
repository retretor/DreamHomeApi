using DreamHomeApi.Data;
using DreamHomeApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<BranchService>();
builder.Services.AddScoped<ClientService>();
builder.Services.AddScoped<LeaseService>();
builder.Services.AddScoped<PrivateOwnerService>();
builder.Services.AddScoped<StaffService>();
builder.Services.AddScoped<ViewingService>();
builder.Services.AddScoped<PropertyForRentService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RentDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});


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