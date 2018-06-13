using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestApp.Infrastructure.Routing
{
    public class LegacyRoute :RouteBase
    {
        private string[] OldTargetUrl;

        public LegacyRoute(params string[] oldTargetUrl)
        {
            this.OldTargetUrl = oldTargetUrl;
        }
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {

            // create new routeData object and required values
            RouteData result = null;

            var relativeUrl = httpContext.Request.AppRelativeCurrentExecutionFilePath;

            if (OldTargetUrl.Contains(relativeUrl, StringComparer.OrdinalIgnoreCase))
            {
                result = new RouteData(this, new MvcRouteHandler());
                result.Values.Add("controller", "Legacy");
                result.Values.Add("action", "GetLegacyUrl");
                result.Values.Add("legacyUrl", relativeUrl);

            }

            return result;
        }
        
        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            //throw new NotImplementedException();
            return new VirtualPathData(this, "~/Home/Index");
        }

    }
}