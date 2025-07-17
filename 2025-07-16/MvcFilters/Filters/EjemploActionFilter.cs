using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Filters
{
    public class EjemploActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("[EjemploActionFilter] OnActionExecuted: " + filterContext.ActionDescriptor.ActionName);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("[EjemploActionFilter] OnActionExecuting: " + filterContext.ActionDescriptor.ActionName);
        }
    }
}