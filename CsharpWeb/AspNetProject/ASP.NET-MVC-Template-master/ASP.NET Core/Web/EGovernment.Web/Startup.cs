namespace EGovernment.Web
{
    using System.Reflection;

    using CloudinaryDotNet;
    using EGovernment.Data;
    using EGovernment.Data.Common;
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models;
    using EGovernment.Data.Repositories;
    using EGovernment.Data.Seeding;
    using EGovernment.Services.Data;
    using EGovernment.Services.Data.AddressServices;
    using EGovernment.Services.Data.EmployeesService;
    using EGovernment.Services.Data.Heath;
    using EGovernment.Services.Data.MinistryService;
    using EGovernment.Services.Mapping;
    using EGovernment.Services.Messaging;
    using EGovernment.Web.ViewModels;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection")));

            // removed this one to add the one bellow with the RoleManager!
            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
             .AddRoles<ApplicationRole>()
             .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddAuthentication()
            //  .AddFacebook(facebookOptions =>
            //{
            //    facebookOptions.AppId = this.configuration["AppId"]; // Authentication:Facebook
            //    facebookOptions.AppSecret = this.configuration["AppSecret"]; // Authentication:Facebook:
            //})
            //.AddGoogle(options =>
            //{
            //    IConfigurationSection googleAuthNSection =
            //         this.configuration.GetSection("Authentication:Google");

            //    options.ClientId = googleAuthNSection["ClientId"];
            //    options.ClientSecret = googleAuthNSection["ClientSecret"];
            //});

            services.Configure<CookiePolicyOptions>(
                options =>
                    {
                        options.CheckConsentNeeded = context => true;
                        options.MinimumSameSitePolicy = SameSiteMode.None;
                    });

            services.AddControllersWithViews(configure =>
            {
                configure.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            //services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddRazorPages();

            Account account = new Account(
                             this.configuration["Cloudinary:AppName"],
                             this.configuration["Cloudinary:AppKey"],
                             this.configuration["Cloudinary:AppSecret"]);

            Cloudinary cloudinary = new Cloudinary(account);

            services.AddSingleton(cloudinary);

            services.AddSingleton(this.configuration);

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IDbQueryRunner, DbQueryRunner>();

            // Application services
            services.AddTransient<IEmailSender>(a => new SendGridEmailSender("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"));

            // services.AddTransient<IEmailSender, NullMessageSender>();
            services.AddTransient<ISettingsService, SettingsService>();
            services.AddTransient<IMinistryService, MinistryService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IHealthService, HealthService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            // Seed data on application startup
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (env.IsDevelopment())
                {
                    dbContext.Database.Migrate();
                }

                new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(
                endpoints =>
                    {
                        endpoints.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                        endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                        endpoints.MapRazorPages();
                    });
        }
    }
}
