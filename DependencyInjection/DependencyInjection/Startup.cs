using DependencyInjection.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public class Startup
    {
        private IHostingEnvironment env;

        public Startup(IHostingEnvironment hostEnv) => env = hostEnv;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddTransient<IModelStorage, DictionaryStorage>();
            services.AddTransient<ProductTotalizer>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
        }
    }
}

/*
 *             services.AddScoped<IRepository, MemoryRepository>();
 * 
 *             // for every Irepository call the app will check wheter its in development or not and then return a instance of the class
            services.AddTransient<IRepository>(provider =>
           {
               if (env.IsDevelopment())
               {
                   var x = provider.GetService<MemoryRepository>();
                   return x;
               }
               else
               {
                   return new AlternateRepository();
               }
           });
            //  TypeBroker.SetRepositoryType<AlternateRepository>();
            services.AddTransient<MemoryRepository>();
 */
