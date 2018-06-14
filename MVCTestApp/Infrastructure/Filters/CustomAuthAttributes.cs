using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestApp.Infrastructure.Filters
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool OnlyLocalRequest;


        public CustomAuthAttribute():this(false)
        {

        }
        public CustomAuthAttribute(bool OnlyLocal)
        {
            this.OnlyLocalRequest = OnlyLocal;
        }


        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool result = false ;
            //todo
            if( httpContext.Request.IsAuthenticated)
            {
               //...
            }

            if (OnlyLocalRequest)
            {
                result =  httpContext.Request.IsLocal;
            }
            
            //todo
            if (httpContext.Request.IsSecureConnection)
            {
               ///...
            }
            return result;
           // return base.AuthorizeCore(httpContext);
        }

    }
}