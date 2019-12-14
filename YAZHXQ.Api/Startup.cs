using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using YAZHXQ.Common;
using YAZHXQ.IService;
using YAZHXQ.Models.Models;
using YAZHXQ.Service;

namespace YAZHXQ.Api
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
    {    //注入mysql数据库上下文
      services.AddDbContext<YAZHXQMysqlContext>(options => options.UseMySql(Configuration.GetConnectionString("Mysql")));

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      //配置EF服务注册
      //services.AddDbContext<YAXQZHYYContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));


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
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
