using System;
using GenericRepositoryPractice.DataAccessLayer.Context;
using GenericRepositoryPractice.DataAccessLayer.Implementation;
using GenericRepositoryPractice.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPractice
{
    public static class RegisterServices
    {
        public static void Register(this IServiceCollection services,IConfiguration config)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork,UnitOfWork>();
        }
    }
}
