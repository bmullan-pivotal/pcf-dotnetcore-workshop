﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using Steeltoe.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;


namespace Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseCloudFoundryHosting()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((builderContext, config) =>
                {
                    config.SetBasePath(builderContext.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{builderContext.HostingEnvironment.EnvironmentName}.json", optional: true)
                        .AddCloudFoundry()
                        .AddEnvironmentVariables();
                })
                .ConfigureLogging((builderContext, loggingBuilder) =>
                {
                    loggingBuilder.AddConfiguration(builderContext.Configuration.GetSection("Logging"));
                    loggingBuilder.AddDynamicConsole();
                    loggingBuilder.AddDebug();
                })
                .Build();

            host.Run();
        }

       // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
         //   WebHost.CreateDefaultBuilder(args)
            //    .UseStartup<Startup>();
    }
}
