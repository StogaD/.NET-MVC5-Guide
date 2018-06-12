using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace MvcGuideUT.HttpMock
{
    class HttpContextMock
    {
        public static  RequestContext GetHttpRequest(RouteData  routeData)
        {
            var httpContext = new RequestContext
            {
                RouteData = routeData
            };

            return httpContext;

        }

        
    }
}
