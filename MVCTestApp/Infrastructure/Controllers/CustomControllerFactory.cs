using MVCTestApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace AirPlane.WebUI.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        // controllerName from the url
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;
            switch(controllerName)
            {
                case "Product":
                    {
                        targetType = typeof(CustomerController);
                  
                      
                    }
                    break;
                case "Customer":
                    {
                        targetType = typeof(CustomerController);
                    }
                    break;
                default:
                    targetType = typeof(CustomerController);
                    requestContext.RouteData.Values["controller"] = "Product";
                    break;
            }


            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
       //  return targetType == null ? null : (IController)Activator.CreateInstance(targetType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            switch(controllerName)          //[SessionState(SessionStateBehavior.Disabled)] in DefaultControllerFactory
            {
                case "Customer":
                    return SessionStateBehavior.ReadOnly;
                default:  return SessionStateBehavior.Default;
            }
           
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}