using Data.BaseRepository;
using Data.Entity;
using Data.Entity.Models;
using Infrastructure.Utilities;
using Infrastructure.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Presentation.Dashboard.Resources;
using System.Globalization;
using System.Reflection;

namespace Presentation.Dashboard
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
            #region Add language web
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddSingleton<LocalizationService>();
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        var assemblyName = new AssemblyName(typeof(ApplicationResource).GetTypeInfo().Assembly.FullName);
                        return factory.Create("ApplicationResource", assemblyName.Name);
                    };
                });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                //https://www.localeplanet.com/index.html
                var supportedCultures = new[]
                {
                    new CultureInfo("vi"),
                    new CultureInfo("en"),
                };

                options.DefaultRequestCulture = new RequestCulture("vi");

                options.SupportedCultures = supportedCultures;

                options.SupportedUICultures = supportedCultures;
            });
            #endregion

            #region Add framework services.
            services
            .AddControllersWithViews()
            .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            #endregion

            #region Add Kendo UI 
            services.AddKendo();
            #endregion

            #region Add DbConnect
            //Add DbConnect
            var conn = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<GvResourceContext>(options => options.UseSqlServer(conn));
            //Add UnitOfWork & Repository
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddOptions();
            // Hook our MyOptions class up to the corresponding appsettings section
            services.Configure<Settings>(Configuration.GetSection(Settings.SectionName));
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            #region Add language web
            var requestlocalizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(requestlocalizationOptions.Value);
            #endregion
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
