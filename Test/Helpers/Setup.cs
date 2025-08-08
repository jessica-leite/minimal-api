using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using MinimalApi.Dominio.Interfaces;
using Test.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Helpers;

public class Setup
{
    public const string Port = "5001";
    public static TestContext TestContext = default!;
    public static WebApplicationFactory<Startup> http = default!;
    public static HttpClient client = default!;

    public static void ClassInit(TestContext testContext)
    {
        Setup.TestContext = testContext;
        Setup.http = new WebApplicationFactory<Startup>();
        Setup.http = Setup.http.WithWebHostBuilder(builder =>
        {
            builder.UseSetting("https_port", Setup.Port).UseEnvironment("Testing");
            builder.ConfigureServices(services =>
            {
                services.AddScoped<IAdministradorServico, AdministradorServicoMock>();
                services.AddScoped<IVeiculoServico, VeiculoServicoMock>();
            });
        });

        Setup.client = Setup.http.CreateClient();
    }
    
    public static void ClassCleanup()
    {
        Setup.http.Dispose();
    }
}