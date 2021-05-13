using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using CRM.API.Infrastructure.IoC;
using CRM.Application.Interfaces;
using CRM.Application.Services;
using CRM.Data.GenericRepository;
using CRM.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CRM.Domain.Models.SendGrid;
using CRM.API.Infrastructure.EmailSender;

namespace CRM.API
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
            string ConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.Configure<EmailCredientials>(Configuration.GetSection("SendGrid"));
            services.AddControllers();
            Dependencies.Inject(services,ConnectionString);

            /*********************************** Email Dependency ****************************************/
            services.AddTransient(typeof(IEmailNotification<>), typeof(EmailNotifaction<>));

            /************************** Staff services and repositories **********************************/
            services.AddTransient<IOrderService,OrderService>(); //Add dependencies
            services.AddTransient<IOrderRepository,OrderRepository>();

            /************************** Recipient services and repositories **********************************/
            services.AddTransient<IRecipientService,RecipientService>(); //Add dependencies
            services.AddTransient<IRecipientRepository,RecipientRepository>();

            /************************** Customer services and repositories **********************************/
            services.AddTransient<ICustomerService,CustomerService>(); //Add dependencies
            services.AddTransient<ICustomerRepository,CustomerRepository>();

            /************************** CustSummary services and repositories **********************************/
            services.AddTransient<ICustomerSummaryService,CustomerSummaryService>(); //Add dependencies
            services.AddTransient<ICustomerSummaryRepository,CustomerSummaryRepository>();

             /************************** CustomerSubscriptionPlan services and repositories **********************************/
            services.AddTransient<ICustomerSubscriptionPlanService,CustomerSubscriptionPlanService>(); //Add dependencies for Add/Get CustomerSubscriptionPlan
            services.AddTransient<ICustomerSubscriptionPlanRepository,CustomerSubscriptionPlanRepository>();

             /************************** CustomerSubscription services and repositories **********************************/
            services.AddTransient<ICustomerSubscriptionService,CustomerSubscriptionService>(); //Add dependencies for CustomerSubscriptions
            services.AddTransient<ICustomerSubscriptionRepository,CustomerSubscriptionRepository>();

              /************************** CustomerFavourites services and repositories **********************************/
            services.AddTransient<ICustomerFavouriteService,CustomerFavouriteService>(); //Add dependencies for Default Value CustomerFavourites
            services.AddTransient<ICustomerFavouriteRepository,CustomerFavouriteRepository>();

             /************************** Discounts services and repositories **********************************/
            services.AddTransient<IDiscountService,DiscountService>(); //Add dependencies
            services.AddTransient<IDiscountRepository,DiscountRepository>();

             /************************** UpcomingOrders services and repositories **********************************/
            services.AddTransient<IUpcomingOrderService,UpcomingOrderService>(); //Add dependencies for Default Value UpcomingOrders
            services.AddTransient<IUpcomingOrderRepository,UpcomingOrderRepository>();

             /************************** CustomerActivityLog for CustomerSummary services and repositories **********************************/
            services.AddTransient<ICustomerActivityLogService,CustomerActivityLogService>(); //Add dependencies
            services.AddTransient<ICustomerActivityLogRepository,CustomerActivityLogRepository>();
            
             /************************** CRMClient services and repositories **********************************/
            services.AddTransient<ICRMClientService,CRMClientService>(); //Add dependencies
            services.AddTransient<ICRMClientRepository,CRMClientRepository>();

            /************************** CRMRecipient services and repositories **********************************/
            services.AddTransient<ICRMRecipientService,CRMRecipientService>(); //Add dependencies
            services.AddTransient<ICRMRecipientRepository,CRMRecipientRepository>();            
            
            /************************** CRMRecipient services and repositories **********************************/
            services.AddTransient<ICRMCustomerCountService,CRMCustomerCountService>(); //Add dependencies
            services.AddTransient<ICRMCustomerCountRepository,CRMCustomerCountRepository>();

            /************************** SearchProductsByTags services and repositories **********************************/
            services.AddTransient<ISearchProductsByTagService,SearchProductsByTagsService>(); //Add dependencies
            services.AddTransient<ISearchProductsByTagsRepository,SearchProductsByTagsRepository>();

              /************************** SearchProductsByTags services and repositories **********************************/
            services.AddTransient<IProductOrderService,ProductOrderService>(); //Add dependencies
            services.AddTransient<IProductOrderRepository,ProductOrderRepository>();

             /************************** FloristDashboard services and repositories **********************************/
            services.AddTransient<IFloristDashboardService,FloristDashboardService>(); //Add dependencies
            services.AddTransient<IFloristDashboardRepository,FloristDashboardRepository>();

             /************************** Vendor List services and repositories **********************************/
            services.AddTransient<IVendorService,VendorService>(); //Add dependencies
            services.AddTransient<IVendorRepository,VendorRepository>();

             /************************** Client Subscription List services and repositories **********************************/
            services.AddTransient<ICRMSubscriptionPlanListService,SubscriptionPlanListService>(); //Add dependencies
            services.AddTransient<ICRMClientSubscriptionPlanRepository,ClientSubscriptionPlanListRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseRouting();
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
