using MVCTestApp.Controllers;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestApp
{
    internal class CustomControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            return (IController)DependencyResolver.Current.GetService(typeof(HomeController));
        }
    }
}