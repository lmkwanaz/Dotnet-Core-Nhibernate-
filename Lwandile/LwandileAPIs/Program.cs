using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICM.JHB.Utility.Ninject;
using LwandileAPIs.Ioc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LwandileAPIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start();
             CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void Start()
        {
            //log4net.Config.XmlConfigurator.Configure();
            //logger = LogManager.GetLogger("CIS Event Store");
            Ninject_IOC.Container.Load(new Ninject.Core.IModule[] { new LwandieModule() });
            //created a method so it can call the method to add A user.
            //Ninject_IOC.Container.Get<QauverDomain>().AddUser();

        }
    }
}
