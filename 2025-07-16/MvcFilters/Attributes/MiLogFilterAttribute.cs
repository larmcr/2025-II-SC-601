using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Attributes
{
    public class MiLogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("[MiLogFilterAttribute] OnActionExecuting: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("[MiLogFilterAttribute] OnActionExecuted: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("[MiLogFilterAttribute] OnResultExecuting: " + filterContext.Controller);
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("[MiLogFilterAttribute] OnResultExecuted: " + filterContext.Controller);
            base.OnResultExecuted(filterContext);
        }
    }
}