using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.DataAnnotations;
using CloverleafTrack.ServiceModel;

namespace CloverleafTrack.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
