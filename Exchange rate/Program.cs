using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exchange_rate.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Exchange_rate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // создаем три объекта Rate
            //    Rate rate1 = new Rate { Name = "USD", Value = 36 };
            //    Rate rate2 = new Rate { Name = "EUR", Value = 45 };
            //    Rate rate3 = new Rate { Name = "CNY", Value = 5 };

            //    //добавляю их в бд
            //    db.Rates.Add(rate1);
            //    db.Rates.Add(rate2);
            //    db.Rates.Add(rate3);
            //}
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
