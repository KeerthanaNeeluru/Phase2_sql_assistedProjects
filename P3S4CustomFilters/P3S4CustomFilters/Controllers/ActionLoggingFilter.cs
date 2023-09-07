using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace P3S4CustomFilters.Controllers
{
    public class ActionLoggingFilter : ActionFilterAttribute
    {
      public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext) => Log("OnResultExecuting", filterContext.RouteData);
        private void Log(string methodName,RouteData routeData)
        {
            var controllectName = routeData.Values["contoller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0}-controller:{1} action: {2}", methodName,controllectName,actionName);
            Debug.WriteLine(message);

        }
    }
}
