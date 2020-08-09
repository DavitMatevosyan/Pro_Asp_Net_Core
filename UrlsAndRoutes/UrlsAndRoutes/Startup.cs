using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using UrlsAndRoutes.infrastructure;

namespace UrlsAndRoutes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options =>
            {
                options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint));
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //     app.UseMvcWithDefaultRoute(); // {controller}/{action}/{id?}
            app.UseMvc(routes =>
            {
             //   routes.MapRoute("newRoute", "App/Do{action}", new { controller = "Home" });
                routes.MapRoute("areas", "{area:exists}/{controller=Home}/{action=Index}");
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute("out", "outbound/{controller=Home}/{action=Index}");
                routes.Routes.Add(new LegacyRoute(app.ApplicationServices, 
                                        "/articles/windows_3.1_overview.html",
                                        "/old/.Net_1.0_class_library"));

            });
        }
    }
}



/*
    app.UseMvc(routes =>
            {
                routes.MapRoute("MyRoute", "{controller=Home}/{action=Index}/{id:int?"=DefaultId}/{*catchall}+"}", new { id = new IntRouteConstraint() });
                routes.MapRoute("", "{controller:regex(^H.*)=Home}/{action:regex(^Index$|^About$)}/{id:alpha:minlength(6)?}"id:weekday?, new
                {
                    id = new CompositeRouteConstraint(
                                                                                                                                                   new IRouteConstraint[] {
                                                                                                                                                   new AlphaRouteConstraint(),
                                                                                                                                                   new MinLengthRouteConstraint(6)}
                                                                                                                                                   new WeekDayConstraint())
                });
                routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });
                routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });
                routes.MapRoute("default", "{controller=Home}/{action=Index}",new { action = "Index" });
                routes.MapRoute("", "public/{controller=Home}/{action=Index}"); 

            });            
    
*/
