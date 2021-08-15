using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Site1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testebancopalavras {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options => {
                //Providers - Bibliotecas Conex�es com Bancos - SqlServer, MySQL, Oracle, Postgree, Firebird, DB2...
                //options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;Integrated Security=True");

                options.UseSqlite("Data Source=Database\\site01.db");
            });

            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            //app.UseEndpoints(endpoints => {
            //    endpoints.MapGet("/", async context => {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
