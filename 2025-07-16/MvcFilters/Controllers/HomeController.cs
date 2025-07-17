using MvcFilters.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Controllers
{
    [MiLogFilter]
    [HandleError(View = "MiErrorView")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception("Ejemplo de Exception");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        // [Authorize]
        // [ActionName("OtroNombre")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [NonAction]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("[HomeController] OnActionExecuting: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuting(filterContext);
        }

        [NonAction]
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("[HomeController] OnActionExecuted: " + filterContext.ActionDescriptor.ActionName);
            base.OnActionExecuted(filterContext);
        }
    }
}