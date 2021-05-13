using Admin.API.Commands;
using Admin.API.Events;
using Admin.API.Infrastructure.BlobStorage.Models;
using Admin.API.Infrastructure.BlobStorage.Service;
using Admin.API.Infrastructure.IoC;
using Admin.Application.Interfaces;
using Admin.Application.Interfaces.Product;
using Admin.Application.Services;
using Admin.Application.Services.Product;
using Admin.Data.GenericRepository;
using Admin.Domain.Interfaces;
using Admin.Domain.Interfaces.Product;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Azure.Storage.Blobs;
using BuildingBlocks;
using BuildingBlocks.RabbitMq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Admin.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IContainer Container { get; private set; }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string authUrl = Configuration.GetValue<string>("authentication:angularUrl").ToString();
            string ConnectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddControllers();

            services.AddAuthentication("Bearer").AddJwtBearer("Bearer", config =>
            {
                config.Authority = authUrl;
                config.Audience = "angular";
                config.SaveToken = true;

            });
            services.AddAuthorization();
            Dependencies.Inject(services);

            /**** services and repositories ****/
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IAdminService, AdminService>();

            /**** Staff services and repositories ****/
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IStaffRepository, StaffReposiory>();

            /**** HomeScreen  Services and Repositories ****/
            services.AddTransient<IHomeScreenService, HomeScreenService>();
            services.AddTransient<IHomeScreenRepository, HomeScreenReposiory>();
            services.AddTransient<IHomeScreenService, HomeScreenService>();

            /**** GlobalCode  Services and Repositories ****/
            services.AddTransient<IGlobalCodeService, GlobalCodeService>();
            services.AddTransient<IGlobalCodeRepository, GlobalCodeReposiory>();

            /**** Product Services and Repositories ****/
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IVendorService, VendorService>();
            services.AddTransient<IVendorRepository, VendorRepository>();

            /**** Subscription Plan Services and Repositories ****/
            services.AddTransient<ISubscriptionPanService, SubscriptionPlanService>();
            services.AddTransient<ISubscriptionPlanRepository, SubscriptionPlanRepository>();

            /**** Note  Services and Repositories ****/
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<INoteRepository, NoteReposiory>();

            /**** GlobalCode  Services and Repositories ****/
            services.AddTransient<ITagCollectionService, TagCollectionService>();
            services.AddTransient<ITagCollectionRepository, TagCollectionRepository>();

            /**** Roles Services and Repositories ****/
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<IRolesRepository, RolesRepository>();

            /************************* Task Services and Repositories *********************************/
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<ITaskRepository, TaskRepository>();
            
            /*** Tag Services and Repositories ***/
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<ITagRepository, TagRepository>();


            /*** FloristLogo Services and FloristLogoAndColorCodes ***/
            services.AddTransient<IFloristLogoAndColorCodesService, FloristLogoAndColorCodesService>();
            services.AddTransient<IFloristLogoAndColorCodesRepoditory, FloristLogoAndColorCodesRepository>();

             /*** Theme Services and ThemeAttributes ***/
            services.AddTransient<IThemeAttributesService, ThemeAttributesService>();
            services.AddTransient<IThemeAttributesRepository, ThemeAttributesRepository>();

             /*** Role And Permission Services and ThemeAttributes ***/
            services.AddTransient<IRoleAndPermissionService, RoleAndPermissionService>();
            services.AddTransient<IRoleAndPermissionRepository, RoleAndPermissionRepository>();

             /*** Task Services and ThemeAttributes ***/
            services.AddTransient<IProductCatalogService, ProductCatalogService>();
            services.AddTransient<IProductCatalogRepository, ProductCatalogRepository>();
            
            /*** Configure blob storage credientials ***/
            services.Configure<BlobConfig>(Configuration.GetSection("BlobConfig"));
            services.AddTransient<IBlobStorage, BlobStorage>();
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.AddRabbitMq();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
         
            app.UseRabbitMq()
                .SubscribeCommand<CreateCustomerCommand>()
                .SubscribeEvent<CustomerCreatedSuccessEvent>();
            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRM Microservice V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
