using System;
using NUnit.Framework;
using MvcGuideUT.HttpMock;
using Moq;
using System.Web;
using System.Web.Routing;
using MvcGuides.Controllers;
using System.IO;

namespace MvcGuideUT.Controllers
{
    [TestFixture]
    public class BaseControllerTest
    {

        private Mock<RouteData> routeDataMock;
        private Mock<Route> routeMock;
        private Mock<IRouteHandler> routeHandlerMock;
        private Mock<RequestContext> requestContextMock;

        private HttpContextBase rmContext;
        private HttpRequestBase rmRequest;
        private Mock<HttpContextBase> moqContext;
        private Mock<HttpRequestBase> moqRequest;
        private Mock<HttpResponseBase> moqResponse;
        private Mock<RouteData> moqRoutData;

        [SetUp]
        public  void Setup()
        {
            routeDataMock = new Mock<RouteData>();
            routeHandlerMock = new Mock<IRouteHandler>();
            routeMock = new Mock<Route>();
            requestContextMock = new Mock<RequestContext>();

        }

        [Test]
        public void TestController()
        {

            //TODO:
            moqContext = new Mock<HttpContextBase>();
            moqRequest = new Mock<HttpRequestBase>();
            moqResponse= new Mock<HttpResponseBase>();
            moqRoutData = new Mock<RouteData>();
            moqContext.Setup(x => x.Request).Returns(moqRequest.Object);
            moqContext.Setup(x => x.Response).Returns(moqResponse.Object);
            moqResponse.Setup(x => x.Write(It.IsAny<string>()));


            requestContextMock.SetupGet(x => x.HttpContext).Returns(moqContext.Object);
            requestContextMock.SetupGet(x => x.RouteData).Returns(moqRoutData.Object);
   

            var controller = new BaseController();
            controller.Execute(requestContextMock.Object);

            moqResponse.Verify(x => x.Write(It.IsAny<string>()), Times.Once);
        }
    }
}
