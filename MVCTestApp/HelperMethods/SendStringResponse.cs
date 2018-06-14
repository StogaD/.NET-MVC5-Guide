using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.HelperMethods
{
    public static class SendStringResponse
    {
        public static void Send(this  Controller  controller, string message)
        {
            controller.HttpContext.Response.Write(message);
        }
    }
}