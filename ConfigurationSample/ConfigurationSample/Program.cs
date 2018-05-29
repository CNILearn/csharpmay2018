using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder configBuilder = new ConfigurationBuilder();
            IConfigurationRoot config = configBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            var val1 = config["mysetting1"];
            Console.WriteLine(val1);

            var conn1 = config.GetSection("ConnectionStrings")["conn1"];
            Console.WriteLine(conn1);

            var conn2 = config.GetConnectionString("conn1");
            Console.WriteLine(conn2);

        }
    }
}
