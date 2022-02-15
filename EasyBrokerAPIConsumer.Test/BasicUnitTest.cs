using EasyBrokerAPIConsumer.Domain.Classes;
using EasyBrokerAPIConsumer.Domain.Interfaces;
using EasyBrokerAPIConsumer.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Test
{
    [TestClass]
    public class BasicUnitTest
    {

        [TestMethod("Should raise Unauthorized exception when API Key is wrong.")]
        public async Task Should_raise_Unauthorized_exception_when_API_Key_is_wrong()
        {
            var ex = await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
            {
                using (var consumer = new APIConsumer("https://api.stagingeb.com/v1", "Luck...I'm your father..."))
                {
                    await consumer.GetPropertiesAsync();
                };
            });

            Assert.IsTrue(ex.StatusCode == HttpStatusCode.Unauthorized);
        }

        [TestMethod("Should raise time out exception.")]
        public async Task Should_rise_time_out_exception()
        {
            var ex = await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
            {
                using (var cts = new CancellationTokenSource())
                {
                    cts.CancelAfter(TimeSpan.FromMilliseconds(10));

                    using (var consumer = new APIConsumer("https://api.stagingeb.com/v1", "l7u502p8v46ba3ppgvj5y2aad50lb9"))
                    {
                        await consumer.GetPropertiesAsync(cts.Token);
                    };
                }
            });

            Assert.IsTrue(ex.InnerException is TaskCanceledException);
        }
    }
}
