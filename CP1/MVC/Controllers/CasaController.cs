using MVC;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CasaController : Controller
    {
        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(ClienteModel cliente)
        {
            cliente.EsValido = ModelState.IsValid;
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Identificacion(int id)
        {
            ViewBag.Id = id;
            return View("Identificacion");
        }
    }
}