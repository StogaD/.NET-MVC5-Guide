using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Infrastructure.Actions
{
    public class CustomActionInvokerMvcBased : ControllerActionInvoker
    {
        public override bool InvokeAction(ControllerContext controllerContext, string actionName)
        {

            if (actionName.ToLower().Contains("show"))
            {
                controllerContext.HttpContext.Response.Write("This action is forbiden");
                return true;
            }
            else
            {
            return base.InvokeAction(controllerContext, actionName);
            }


        }

    }
}