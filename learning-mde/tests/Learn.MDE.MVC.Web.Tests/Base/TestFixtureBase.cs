using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Learn.MDE.MVC.Web.Tests.Base
{
    public abstract class TestFixtureBase
    {
        public WebApplicationFactory<Program>? WebApp { get; private set; }
        public HttpClient? RestClient { get; set; }

        protected IReadOnlyList<Endpoint>? Endpoints { get; private set; }
        protected IEnumerable<EndpointDataSource> EndpointDataSources { get; private set; }


        [OneTimeSetUp]
        public async Task GlobalSetup()
        {

            //
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
            Environment.SetEnvironmentVariable("TESTING_WITH_TESTFIXTUREBASE", "TestFixtureBase");

            if (WebApp == null)
            {
                WebApp = new WebApplicationFactory<Program>();
            }

            if (RestClient == null)
            {
                RestClient = this.WebApp.CreateClient();
            }

            this.EndpointDataSources = WebApp.Services.GetServices<EndpointDataSource>();
            this.Endpoints = WebApp.Services.GetService<EndpointDataSource>()?.Endpoints;
        }

        public IServiceProvider GetServiceProvider<T>()
        {
            var scope = WebApp!.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;
            var service = serviceProvider.GetService(typeof(T));
            return serviceProvider;
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            RestClient?.Dispose();
            WebApp?.Dispose();
        }
    }
}
