using System.Web.Mvc;

namespace CP2.Attributes
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("[Log] OnActionExecuting: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("[Log] OnActionExecuted: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("[Log] OnResultExecuting: " + filterContext.Controller);
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("[Log] OnResultExecuted: " + filterContext.Controller);
            base.OnResultExecuted(filterContext);
        }
    }
}