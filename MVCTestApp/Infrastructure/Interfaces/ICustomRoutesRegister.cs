using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace MVCTestApp.Infrastructure.Interfaces
{
    interface ICustomRoutesRegister
    {

       void RegisterCustomRoutes(RouteCollection routes);

     
    }
}
