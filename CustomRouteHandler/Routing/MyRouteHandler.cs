using System.Web;
using System.Web.Routing;

namespace CustomRouteHandler.Routing
{
    public class MyRouteHandler: IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MyHttpHandler();
        }
    }
}