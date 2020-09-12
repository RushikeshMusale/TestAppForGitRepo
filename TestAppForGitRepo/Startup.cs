***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
***REMOVED***
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TestAppForGitRepo
***REMOVED***
    public class Startup
    ***REMOVED***
        public Startup(IConfiguration configuration)
        ***REMOVED***
            Configuration = configuration;
***REMOVED***

        public IConfiguration Configuration ***REMOVED*** get; ***REMOVED***

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        ***REMOVED***
            services.Configure<CookiePolicyOptions>(options =>
            ***REMOVED***
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
    ***REMOVED***);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
***REMOVED***

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        ***REMOVED***
            if (env.IsDevelopment())
            ***REMOVED***
                app.UseDeveloperExceptionPage();
    ***REMOVED***
            else
            ***REMOVED***
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
    ***REMOVED***

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            ***REMOVED***
                routes.MapRoute(
                    name: "default",
                    template: "***REMOVED***controller=Home***REMOVED***/***REMOVED***action=Index***REMOVED***/***REMOVED***id?***REMOVED***");
    ***REMOVED***);
***REMOVED***
***REMOVED***
***REMOVED***
