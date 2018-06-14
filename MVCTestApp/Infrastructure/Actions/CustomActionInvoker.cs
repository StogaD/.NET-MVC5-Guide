using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Infrastructure.Actions
{
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName.ToLower().Contains("NotInvoke"))
            {
                controllerContext.HttpContext.Response.Write("This action is forbiden by custom actionInvoker");
                return true;
            }

            return true;
        }
    }
}