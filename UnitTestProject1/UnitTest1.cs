using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.AspNetCore.Mvc.Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        
        public async Task MiddlewareTest_ReturnsNotFoundForRequest()
        {
            using var host = await new HostBuilder()
                .ConfigureWebHost(webBuilder =>
                {
                    webBuilder
                        .UseTestServer()
                        .ConfigureServices(services =>
                        {
                            services.AddMyServices();
                        })
                        .Configure(app =>
                        {
                            app.UseMiddleware<MyMiddleware>();
                        });
                })
                .StartAsync();

            ...
}
    }
}
