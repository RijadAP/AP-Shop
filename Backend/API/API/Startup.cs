using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Mapper;
using DataAccessLayer;
using BLL;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperFunctionality));
            services.AddDbContext<APShopContext>();
            
            services.AddControllers();
            services.AddScoped<IProductMenager, ProductMenager>();
            services.AddScoped<IUserMenager, UserMenager>();
            services.AddScoped<IUser, User>();
            services.AddScoped<IValidation, Validation>();
            services.AddScoped<IGuidGenerator, GuidGenerator>();
            services.AddScoped<ICurrentDate, CurrentDate>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
