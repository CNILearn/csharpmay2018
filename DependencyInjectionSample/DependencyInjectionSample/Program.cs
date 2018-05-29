using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var service = new GreetingService();
            //var controller = new HomeController(service);
            //controller.Index();
            ConfigureServices();
            var controller = Container.GetRequiredService<HomeController>();
            controller.Index();
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
