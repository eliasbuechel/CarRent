using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.CarManagerment.Api.Models;
using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.CarManagerment.Infrastructure.Persistence;
using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.CustomerManagement.Api.Models;
using Zbw.Carrent.CustomerManagement.Domain;
using Zbw.Carrent.CustomerManagement.Infrastructure.Persistence;
using Zbw.Carrent.RentalContractManagement.Api.Models;
using Zbw.Carrent.RentalContractManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Infrastructure.Persistence;
using Zbw.Carrent.ReservationManagement.Api.Models;
using Zbw.Carrent.ReservationManagement.Domain;
using Zbw.Carrent.ReservationManagement.Infrastructure.Persistence;


namespace Zbw.CarRent
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CarRentDbContext>(options => options.UseSqlServer("Server=.;Database=CarRent;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;"));
            builder.Services.AddScoped<ICustomerRepository<CustomerRequest, CustomerResponse>, CustomerRepository>();
            builder.Services.AddScoped<ICarRepository<CarRequest, CarResponse>, CarRepository>();
            builder.Services.AddScoped<IRentalContractRepository<RentalContractRequest, RentalContractResponse>, RentalContractRepository>();
            builder.Services.AddScoped<IReservationRepository<ReservationRequest, ReservationResponse>, ReservationRepository>();

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
        }
    }
}