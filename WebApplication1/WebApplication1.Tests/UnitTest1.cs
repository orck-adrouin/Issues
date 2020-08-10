using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using ServiceStack;
using WebApplication1.ServiceModel;

namespace WebApplication1.Tests
{
    public class UnitTest1
    {
        [Test]
        public async Task Async()
        {
            var client = new ServiceStack.JsonServiceClient("http://localhost:26311");

            var requests = new List<HelloAsync>
            {
                new HelloAsync { Name = "roger" },
                new HelloAsync { Name = "fred" },
            };

            var response = await client.SendAllAsync<HelloResponse>(requests, CancellationToken.None).ConfigureAwait(false);

        }

        [Test]
        public void Sync()
        {
            var client = new ServiceStack.JsonServiceClient("http://localhost:26311");

            var requests = new List<HelloSync>
            {
                new HelloSync { Name = "roger" },
                new HelloSync { Name = "fred" },
            };

            var response = client.SendAll<HelloResponse>(requests);
        }
    }
}
