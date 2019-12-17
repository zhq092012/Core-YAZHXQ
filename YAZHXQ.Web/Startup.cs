using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;
using YAZHXQ.Service;
using YAZHXQ.Utils;

namespace YAZHXQ.Web
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
            var dbType = Configuration.GetSection("DbType").Value.ToInt();
            switch (dbType)
            {
                case (int)DbType.Mysql:
                    //注入mysql数据库上下文
                    services.AddDbContext<YAZHXQMysqlContext>(options => options.UseMySql(Configuration.GetConnectionString(DbType.Mysql.ToString())));
                    break;
                case (int)DbType.SqlServer:
                    //注入Sqlserver数据库上下文"b => b.UseRowNumberForPaging()解决分页报错"
                    services.AddDbContext<YAXQZHYYContext>(options => options.UseSqlServer(Configuration.GetConnectionString(DbType.SqlServer.ToString()),b => b.UseRowNumberForPaging()));
                    break;
                default:
                    //注入Sqlserver数据库上下文
                    services.AddDbContext<YAXQZHYYContext>(options => options.UseSqlServer(Configuration.GetConnectionString(DbType.SqlServer.ToString()), b => b.UseRowNumberForPaging()));
                    break;
            }
            AddMyServices(services);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="services"></param>
        private static void AddMyServices(IServiceCollection services)
        {
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();
            services.AddScoped<IStaffInfoService, StaffInfoService>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
