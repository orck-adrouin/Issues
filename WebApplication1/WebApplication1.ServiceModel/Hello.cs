using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace WebApplication1.ServiceModel
{
    [Route("/helloAsync/{Name}", Verbs = "GET")]
    public class HelloAsync : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    [Route("/helloSync/{Name}", Verbs = "GET")]
    public class HelloSync : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}