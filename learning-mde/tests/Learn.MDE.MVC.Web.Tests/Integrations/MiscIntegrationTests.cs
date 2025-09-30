using FluentAssertions;
using Learn.MDE.MVC.Web.Data;
using Learn.MDE.MVC.Web.Models;
using Learn.MDE.MVC.Web.Tests.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Learn.MDE.MVC.Web.Tests.Integrations
{
    public class MiscIntegrationTests : TestFixtureBase
    {
        // Password hasher
        protected PasswordHasher<AppUser> PasswordHasher { get; private set; }

        // Strongly-typed AppShellDbContext (replace DbContext with your actual context type if available)
        protected ApplicationDbContext AppShellDb { get; private set; }

        [OneTimeSetUp]
        public void Setup()
        {
            // Get password hasher
            PasswordHasher = new PasswordHasher<AppUser>();


        }

        // using should_ w-fluent-assert, should get weather from api via rest-http client in base
        [TestCase()] 
        public async Task Should_GetWeatherFromApiViaRestHttpClientFromBase()
        {
            // arrange
            var request = new HttpRequestMessage(HttpMethod.Get, "/WeatherForecast");
            
            // act
            var response = await RestClient!.SendAsync(request);

            // assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            var responseString = await response.Content.ReadAsStringAsync();


            responseString.Should().NotBeNullOrEmpty();
            responseString.Should().Contain("date");
            responseString.Should().Contain("temperatureC");
            responseString.Should().Contain("summary");
        }

    }
}