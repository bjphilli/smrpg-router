using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using SmrpgRouter.DAL;
using SmrpgRouter.Domain;

namespace SmrpgRouter.Web
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
            // Add framework services.
            services.AddMvc();

            const string connectionString =
                "Host=postgres;Port=5432;Database=smrpgRouter;Username=smrpgRouter;Password=smrpgRouter";

            services.AddDbContext<SmrpgContext>(o =>
                o.UseNpgsql(connectionString, b => b.MigrationsAssembly("SmrpgRouter.Domain")));

            services.BootstrapDependencies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }

            app.RunMigrations();
        }
    }

    public static class IApplicationBuilderExtensions
    {
        public static void RunMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            using (var context = serviceScope.ServiceProvider.GetService<SmrpgContext>())
            {
                context.Database.Migrate();
            }
        }
    }
}
