using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder.Services.AddTransient



        await builder.Build().RunAsync();
    }
}
