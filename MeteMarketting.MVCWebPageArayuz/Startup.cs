using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Data.Abstract;
using MeteMarketting.Data.Concreate.EntityFramework;
using MeteMarketting.MVCWebPageArayuz.Entity;
using MeteMarketting.MVCWebPageArayuz.Middlewares;
using MeteMarketting.MVCWebPageArayuz.Servisler;
using MeteMarketting.Workstation.Abstract;
using MeteMarketting.Workstation.Concrate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MeteMarketting.MVCWebPageArayuz
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUrunServis , UrunMan>();
            services.AddScoped<IUrunVeriErisimKatmani,EFUrunVeriErisim >();
            services.AddScoped<IKategoriServis, KategoriMan>();
            services.AddScoped<IKategoriVeriErisimKatmani, EFKategoriVeriErisim>();
            services.AddSingleton<ISepetSessionServis, SepetSessionServis>();
            services.AddSingleton<ISepetServis, SepetServis>();
            services.AddDbContext<CustomKimlikDbContext>
                (options => options.UseSqlServer("Server=DESKTOP-UOB2H8R\\SQLEXPRESS;Database=ECommerce; Trusted_Connection=true"));
            services.AddIdentity<CustomKimlikUser, CustomKimlikRole>()
                .AddEntityFrameworkStores<CustomKimlikDbContext>()
                .AddDefaultTokenProviders();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();

            app.UseNodeModules(env.ContentRootPath);

            app.UseAuthentication();

            app.UseIdentity();

            

            app.UseSession();

            app.UseMvcWithDefaultRoute();
        }
    }
}
