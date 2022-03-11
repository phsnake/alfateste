using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.aspNetCore.Builder;
using Microsoft.aspNetCore.Hosting;
using Microsoft.aspNetCore.HttpsPolicy;
using Microsoft.aspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependecyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace UnityOfShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }

        public Iconfiguration Configuration {get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("database"));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IUnityOfWork, UnityOfWork>();
        }

        // This method gets called by the runtime. use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnviroment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRounting();

        }

    }

}