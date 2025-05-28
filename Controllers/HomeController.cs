using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace TP05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Identificacion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Identificacion(string nombreJugador)
        {
            if (string.IsNullOrWhiteSpace(nombreJugador))
            {
                ViewBag.Error = "Por favor ingresá tu nombre.";
                return View();
            }

            HttpContext.Session.SetString("NombreJugador", nombreJugador);
            return RedirectToAction("Introduccion");
        }

        public IActionResult Introduccion()
        {
            string nombre = HttpContext.Session.GetString("NombreJugador");
            ViewBag.NombreJugador = nombre;
            return View();
        }
    }
}
