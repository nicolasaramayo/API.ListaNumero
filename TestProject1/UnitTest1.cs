using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //[Fact]
        //public async Task MiddlewareTest_ReturnsNotFoundForRequest()
        //{
        //    using var host = await new HostBuilder()
        //        .con(webBuilder =>
        //        {
        //            webBuilder
        //                .UseTestServer()
        //                .ConfigureServices(services =>
        //                {
        //                    services.AddMyServices();
        //                })
        //                .Configure(app =>
        //                {
        //                    app.UseMiddleware<MyMiddleware>();
        //                });
        //        })
        //        .StartAsync();

            
        //}
    }
}
