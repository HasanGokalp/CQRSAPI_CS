
using CQRSAPI.Application.Features.Cars.Queries.GetAllCar;
using CQRSAPI.Persistence.DAOs;
using CQRSAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CQRSAPI.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<CQRSAPICtx>(opt =>
            {
                opt.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ShowRoom3;Trusted_Connection=True;TrustServerCertificate=True");
            });
            
            
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllCarHandler).Assembly));


            builder.Services.AddScoped(typeof(ReadRepository));

            
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
        }
    }
}
