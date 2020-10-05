using Mapster;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UniversityJobCommunicationServiceDotNet.Data;
using UniversityJobCommunicationServiceDotNet.Data.Domain;
using UniversityJobCommunicationServiceDotNet.Data.Model;

namespace UniversityJobCommunicationServiceDotNet
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
            services.AddControllers();

            services.AddSwaggerGen();
            services.AddDbContextPool<AppDbContext>(option =>
                option.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
        }

        // mapper configuration
        /*public class MyRegister : IRegister
        {
            public void Register(TypeAdapterConfig config)
            {
                config.NewConfig<TSource, TDestination>();
            }
        }*/
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}