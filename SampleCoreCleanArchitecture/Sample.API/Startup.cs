using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Core.Models;
using Sample.Core.Repositories;
using Sample.Persistence.MySQL;
using Sample.Persistence.MySQL.Repositories;
using Sample.Service;
using Sample.Service.Interface;
using Swashbuckle.AspNetCore.Swagger;

namespace Sample.API
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
            services.AddMvc();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "NetCoreSample", Version = "v1" });
            });

            // --MySQL
            //services.AddTransient<ICompanyRepository<Company>, CompanyRepository>();
            //services.AddTransient<IPersonRepository<Person>, PersonRepository>();

            // --SQLite
            services.AddTransient<ICompanyRepository<Company>, Sample.Persistence.SQLite.Repositories.CompanyRepository>();
            services.AddTransient<IPersonRepository<Person>, Sample.Persistence.SQLite.Repositories.PersonRepository>();

            services.AddTransient<IPersonService<Person>, PersonService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
            }
            else
            {
            }

            // --ConnectionString Of MySQL
            //ConnectionManager.ConnectionString = "server=localhost;user=root;password=SilverPPS2010;port=3306;database=sample";

            // --ConnectoinString of SQLite
            Sample.Persistence.SQLite.ConnectionManager.ConnectionString = @"Data Source =.\..\Sample.Persistence.SQLite\main.db;Version=3";


            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
