using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.�nterfaces;
using CoreBankaProje.Data.Repositories;
using CoreBankaProje.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBankaProje
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BankContext>(opt =>
            {
                //burdaki opt, BankContext(DbContextOptions<BankContext> options burdaki options yerine gececek
                opt.UseSqlServer("server=DESKTOP-O9RRR03;database=BankaDb;integrated security=true;");
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));//generic olarak y-tan�mlad���nda b�yle tan�mlayacan 
            //art�k a�ah�dakilere gerek yok
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();//biz burda diyoruzki IApplicationUserRepository bunu g�rd���nde ApplicationUserRepository bunu d�nd�r ba��ml�l�k azals�n
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserMapper, UserMapping>();
            services.AddScoped<IAccountMapper, AccountMapper>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//wwwroot klas�r�n� di�ar� a��yorsun 
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
