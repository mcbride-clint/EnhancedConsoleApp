using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EnhancedConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            host.Services.GetRequiredService<Process>().Execute();
        }

        // Asynchronous version of Main
        // Just change Process.Execute() to async Task as well
        /*

        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            await host.Services.GetRequiredService<Process>().Execute();
        }

         */

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<Process>();
                });
    }
}
