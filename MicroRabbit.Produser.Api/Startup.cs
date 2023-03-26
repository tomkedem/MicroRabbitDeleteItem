﻿
using MediatR;
using MicroRabbit.Infra.IoC;
using Microsoft.AspNetCore.Mvc;

using Microsoft.OpenApi.Models;
namespace MicroRabbit.Produser.Api
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
               

                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Produser Microservice", Version = "v1" });
                });

                services.AddMediatR(typeof(Startup));

                RegisterServices(services);
            }

            private void RegisterServices(IServiceCollection services)
            {
                DependencyContainer.RegisterServices(services);
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

                app.UseHttpsRedirection();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Produser Microservice V1");
                });
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
        }
    
}
