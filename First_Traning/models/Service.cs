using First_Traning.Controllers.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Traning.Controllers.model;

namespace First_Traning.models
{
    public static class Service
    {
        public static void AddService(this IServiceCollection serv , IConfiguration config)
        {
            serv.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnecetion")));
            serv.AddScoped<IUserRepo, UserRepo>();
            serv.AddScoped<IPostRepo, PostRepo>();

            serv.AddAutoMapper(typeof(Startup));
            serv.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "swag API",
                    Description = "Api",
                    Version = "V1"
                });
            });
        }
    }
}
