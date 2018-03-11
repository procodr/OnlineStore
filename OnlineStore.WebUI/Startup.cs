using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Domain.Contract.Repositories;
using OnlineStore.Infrustructures.Data.Context;
using OnlineStore.Infrustructures.Data.Repositories;
using OnlineStore.Services.Application;

namespace OnlineStore.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OnlineStoreContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            if(bool.Parse(Configuration["UseCache"]))
                services.AddScoped(typeof(ICustomerRepository), typeof(CachedCustomerRepository));
            else
                services.AddScoped(typeof(ICustomerRepository), typeof(CustomerRepository));
            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
