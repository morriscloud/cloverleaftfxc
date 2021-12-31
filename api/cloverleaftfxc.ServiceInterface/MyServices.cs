using System;
using ServiceStack;
using cloverleaftfxc.ServiceModel;

namespace cloverleaftfxc.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
