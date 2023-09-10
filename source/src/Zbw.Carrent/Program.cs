using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.CarManagerment.Infrastructure.Persistence;
using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.CustomerManagement.Domain;
using Zbw.Carrent.CustomerManagement.Infrastructure.Persistence;
using Zbw.Carrent.RentalContractManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Infrastructure.Persistence;
using Zbw.Carrent.ReservationManagement.Domain;
using Zbw.Carrent.ReservationManagement.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IRentalContractRepository, RentalContractRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddDbContext<CarRentDbContext>(options => options.UseSqlServer("Server=.;Database=CarRent;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();