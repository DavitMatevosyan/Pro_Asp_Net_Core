using ConfiguringApps.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConfiguringApps
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // this will be used in staging and production stage
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<UptimeService>();
            services.AddMvc().AddMvcOptions(options =>
            {
                options.RespectBrowserAcceptHeader = true;
            });
        }

        // this will be used instead of ConfigureServices() method during Development stage
  //      public void ConfigureDevelopmentServices(IServiceCollection services)
  //      {
  //          services.AddSingleton<UptimeService>();
  //          services.AddMvc();
  //      }

        // this will be used during stagin and production stage.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }

        // this will be used instead of Configure() during development stage
    //    public void ConfigureDevelopment(IApplicationBuilder app, IHostingEnvironment env)
    //    {
    //        app.UseDeveloperExceptionPage();
    //        app.UseStatusCodePages();
    //        app.UseStaticFiles();
    //        app.UseMvcWithDefaultRoute();
    //    }
    }
}
