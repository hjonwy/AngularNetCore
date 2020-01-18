using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AngularCore31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder hostBuiler = Host.CreateDefaultBuilder(args);
            hostBuiler.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
            hostBuiler.ConfigureLogging((ctx, logging)=>{
                logging.AddLog4Net();
                logging.SetMinimumLevel(LogLevel.Debug);
            });
            
            return hostBuiler;
        }
    }
}
