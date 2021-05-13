using Admin.API.Infrastructure.Filters;
using AutoMapper;
using AutoMapper.Configuration;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Admin.API.Infrastructure.IoC
{
    public class Dependencies
    {
        public static void Inject(IServiceCollection services)
        {
          
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            
            services.AddMvc(options =>
            {
                options.Filters.Add(new ValidatonFilter());
            })
            .AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblyContaining<Startup>();
            });
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
            services.AddAutoMapper(typeof(Startup));

            //services.AddHealthChecks().AddSqlServer(ConnectionString);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CRM Microservice", Version = "v1" });
            });
        }
    }
}
