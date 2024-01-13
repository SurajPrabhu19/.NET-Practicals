
using System.Text.RegularExpressions;

namespace Routing_Concept.CustomRouteConstraint
{
    public class MonthCustomRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey)) return false; // routekey -> month

            Regex regex = new Regex("^(apr|jul|oct)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (monthValue!=null && regex.IsMatch(monthValue)) return true;
            return false;
        }
    }
}
