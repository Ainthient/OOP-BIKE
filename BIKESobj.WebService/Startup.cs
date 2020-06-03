using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BIKESobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using BIKESobj.ApplicationServices.GetPathLocationListUseCase;
using BIKESobj.ApplicationServices.Ports.Gateways.Database;
using BIKESobj.ApplicationServices.Repositories;
using BIKESobj.DomainObjects.Ports;

namespace BIKESobj.WebService
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
            services.AddDbContext<BIKESobjContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "BIKESobj.db")}")
            );

            services.AddScoped<IBIKESobjDatabaseGateway, BIKESobjEFSqliteGateway>();

            services.AddScoped<DbBIKESobjRepository>();
            services.AddScoped<IReadOnlyBIKESobjRepository>(x => x.GetRequiredService<DbBIKESobjRepository>());
            services.AddScoped<IBIKESobjRepository>(x => x.GetRequiredService<DbBIKESobjRepository>());


            services.AddScoped<IGetBIKESobjListUseCase, GetBIKESobjListUseCase>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}