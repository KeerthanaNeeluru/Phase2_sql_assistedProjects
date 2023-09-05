using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace p3S4Routing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
             Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=index}/{id?}");
                routes.MapRoute(name: "studentId", template: "Student/{id}", defaults: new { controller = "Home", action = "StudentInfo1" });
                routes.MapRoute(name: "studentIdName", template: "Student/{id}/{name}", defaults: new { controller = "Home", action = "StudentInfo1" });
            });

        }
    }
}
