using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Authentication.Infrastructure.IoC.Dependencies;
using Authentication.Infrastructure.IoC.Middlewares;
using AuthIdentityServer.Services;
using AuthIdentityServer.Models;
using IdentityServer4.Services;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using Autofac;
using BuildingBlocks.RabbitMq;
using Authentication.Events;
using System;
using Solution.Data.Interfaces;
using Solution.Data.GenericRepository;
using AuthIdentityServer.Infrastructure.EmailSender;
using AuthIdentityServer.Models.SendGrid;

namespace AuthIdentityServer
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.Configure<EmailCredientials>(Configuration.GetSection("SendGrid"));
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddAuthorization();

            InjectNugetPackages.ConfigureServices(services);
            InjectIdentityServer.ConfigureServices(services, connectionString);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Florist Microservice", Version = "v1" });
            });
            services.AddTransient<ILoginService<ApplicationUser>, EFLoginService>();
            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<IFloristThemeIdRepository,FloristThemeIdRepository>();
            services.AddTransient(typeof(IEmailNotification<>), typeof(EmailNotifaction<>));
            services.AddControllers().AddNewtonsoftJson();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc();
            
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            Console.WriteLine("builder called");
            builder.AddRabbitMq();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("MyPolicy");
            app.UseRabbitMq().SubscribeEvent<CustomerCreatedAuthEvent>();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot")),
                RequestPath = new PathString("/wwwroot")
            });
            app.UseRouting();
            app.UseAuthorization();
            //app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Authenticaton Microservices V1.1");
            });
            app.UseIdentityServer();
            app.UseCookiePolicy(new CookiePolicyOptions { MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Lax });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapHealthChecks("/health");
                endpoints.MapRazorPages();
            });
            InjectMiddlewares.Configure(app, env);
        }
    }
}
