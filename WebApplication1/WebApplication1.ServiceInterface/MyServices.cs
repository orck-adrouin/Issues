using System;
using System.Threading.Tasks;
using ServiceStack;
using WebApplication1.ServiceModel;

namespace WebApplication1.ServiceInterface
{
    public class MyServices : Service
    {
        public async Task<HelloResponse> Any(HelloAsync request)
        {
            await Task.Delay(10).ConfigureAwait(false);

            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        public HelloResponse Any(HelloSync request)
        {

            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}