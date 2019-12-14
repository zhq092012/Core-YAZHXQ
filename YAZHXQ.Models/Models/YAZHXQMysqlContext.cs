//
//  YAZHXQMysqlContext.cs
//
//  Author:
//       zhanghuqiang <1169071140@qq.com>
//
//  Copyright (c) 2019 
using System;
using Microsoft.EntityFrameworkCore;

namespace YAZHXQ.Models.Models
{
  public class YAZHXQMysqlContext : YAXQZHYYContext
  {
    public YAZHXQMysqlContext()
    {
    }

    public YAZHXQMysqlContext(DbContextOptions<YAXQZHYYContext> options) : base(options)
    {
    }

    /// <summary>
    /// 重写确定使用那个活动提供程序进行数据迁移
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;uid=root;pwd=zhq092012;port=3306;database=YAXQZHYY");
  }
}
