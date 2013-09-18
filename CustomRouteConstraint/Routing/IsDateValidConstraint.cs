using System;
using System.Globalization;
using System.Web;
using System.Web.Routing;

namespace CustomRouteConstraint.Routing
{
    public class IsDateValidConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values,
                          RouteDirection routeDirection)
        {
            if (routeDirection == RouteDirection.IncomingRequest)
            {
                DateTime dummyDateTime;

                return DateTime.TryParse(string.Format("{0}/{1}/{2}", values["year"], values["month"], values["day"])
                    , CultureInfo.InvariantCulture, DateTimeStyles.None, out dummyDateTime);
            }

            return true;
        }
    }
}