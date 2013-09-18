using System.Web;

namespace CustomRouteHandler.Routing
{
    public class MyHttpHandler: IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var originatingIpAddress = context.Request.UserHostAddress;

            context.Response.Write(string.Format("The originating IP address is: {0}", originatingIpAddress));
        }

        public bool IsReusable { get; private set; }
    }
}