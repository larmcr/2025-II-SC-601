using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace CP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDictionary<int, bool> items = new Dictionary<int, bool>() 
        {
            { 1, false },
            { 2, false },
            { 3, false },
            { 4, false },
            { 5, false },
            { 6, false },
            { 7, false },
            { 8, false },
            { 9, false },
        };

        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View(items);
        }

        public ActionResult Redirect()
        {
            ViewBag.Title = "Redirect";
            return RedirectToAction("Index");
        }

        public ActionResult Ajax()
        {
            return null;
        }

        public ActionResult Unauth()
        {
            ViewBag.Title = "Unauth";
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }
    }
}
