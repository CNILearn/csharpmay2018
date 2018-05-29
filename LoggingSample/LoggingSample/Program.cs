using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureServices();
            var service = Container.GetService<MyService>();
            service.MyMethod();
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddLogging(builder =>
            {
                builder.AddDebug();
                builder.AddConsole();
            });
            services.AddTransient<MyService>();
            Container = services.BuildServiceProvider();
        }
        public static IServiceProvider Container { get; private set; }
    }
}
